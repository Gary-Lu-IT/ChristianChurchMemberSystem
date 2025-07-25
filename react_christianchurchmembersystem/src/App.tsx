import { useState } from 'react';
import './App.css';
type Announcement = {
    title: string;
    content: string;
    publishDateTime: string;
};
function App() {
    const [showMenu, setShowMenu] = useState<string>('');
    const [announcements, setAnnouncements] = useState<Announcement[]>([]);
    const [showAnnouncementList, setShowAnnouncementList] = useState(false);
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState<string | null>(null);
    const userName = '系統管理員';

    const handleMenuClick = (menu: string) => {
        setShowMenu(showMenu === menu ? '' : menu);
        if (menu === 'announcement') {
            fetchAnnouncements();
            setShowAnnouncementList(true);
        } else {
            setShowAnnouncementList(false);
        }
    };

    const fetchAnnouncements = async () => {
        setLoading(true);
        setError(null);
        try {
            const response = await fetch('http://127.0.0.1:30160/Announcement/GetAnnouncementList', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({}) // 根據API需求調整
            });
            if (!response.ok) throw new Error('伺服器回應失敗');
            const data = await response.json();
            // 假設回傳為陣列
            const sorted = [...data]
                .sort((a, b) => new Date(b.publishDateTime).getTime() - new Date(a.publishDateTime).getTime())
                .slice(0, 10);
            setAnnouncements(sorted);
        } catch (err: any) {
            setError(err.message || '取得公告失敗');
            setAnnouncements([]);
        } finally {
            setLoading(false);
        }
    };

    const logout = () => {
        alert('您已登出');
    };

    return (
        <div>
            <header className="app-header">
                <div className="header-title">
                    <span className="system-name">泛用基督教會會員管理系統</span>
                </div>
                <div className="header-user">
                    <span className="welcome-text">歡迎，{userName}。</span>
                    <button className="btn" onClick={logout}>登出</button>
                </div>
            </header>

            <nav className="app-menu">
                <ul className="nav">
                    <li className="nav-item dropdown">
                        <a
                            className="nav-link dropdown-toggle"
                            href="#"
                            onClick={() => handleMenuClick('member')}
                        >
                            教友資料管理
                        </a>
                        {showMenu === 'member' && (
                            <ul className="dropdown-menu">
                                <li><a className="dropdown-item" href="#">教友基本資料</a></li>
                                <li><a className="dropdown-item" href="#">系統帳戶資料</a></li>
                                <li><a className="dropdown-item" href="#">教友家庭資料</a></li>
                                <li><a className="dropdown-item" href="#">代禱事項管理</a></li>
                            </ul>
                        )}
                    </li>
                    <li className="nav-item">
                        <a
                            className="nav-link"
                            href="#"
                            onClick={() => handleMenuClick('announcement')}
                        >
                            公告管理
                        </a>
                    </li>
                    <li className="nav-item dropdown">
                        <a
                            className="nav-link dropdown-toggle"
                            href="#"
                            onClick={() => handleMenuClick('activity')}
                        >
                            活動管理
                        </a>
                        {showMenu === 'activity' && (
                            <ul className="dropdown-menu">
                                <li><a className="dropdown-item" href="#">活動排程設定</a></li>
                                <li><a className="dropdown-item" href="#">活動資料管理</a></li>
                                <li><a className="dropdown-item" href="#">活動簽到</a></li>
                                <li><a className="dropdown-item" href="#">活動出席狀況</a></li>
                            </ul>
                        )}
                    </li>
                    <li className="nav-item"><a className="nav-link" href="#">奉獻管理</a></li>
                    <li className="nav-item"><a className="nav-link" href="#">統計報表</a></li>
                </ul>
            </nav>

            <main>
                {showAnnouncementList && (
                    <section style={{ margin: '24px' }}>
                        <h2>公告列表</h2>
                        {loading && <div>載入中...</div>}
                        {error && <div style={{ color: 'red' }}>{error}</div>}
                        <ul>
                            {announcements.map((a, idx) => (
                                <li key={idx} style={{ marginBottom: '16px', borderBottom: '1px solid #ccc', paddingBottom: '8px' }}>
                                    <div><strong>{a.title}</strong></div>
                                    <div>{a.content}</div>
                                    <div style={{ fontSize: '0.9em', color: '#888' }}>{new Date(a.publishDateTime).toLocaleString()}</div>
                                </li>
                            ))}
                        </ul>
                        {announcements.length === 0 && !loading && !error && <div>目前沒有公告。</div>}
                    </section>
                )}
            </main>
        </div>
    );
}
export default App;
