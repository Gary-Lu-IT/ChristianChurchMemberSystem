import gradio as gr
import requests
import pandas as pd

# API base URL (change to your actual API endpoint)
API_BASE_URL = "http://localhost:8000/api"

# --- API Placeholder Functions ---
def add_member_api(name, gender, phone, group):
    payload = {"name": name, "gender": gender, "phone": phone, "group": group}
    # res = requests.post(f"{API_BASE_URL}/members", json=payload)
    return f"會員 {name} 資料已送出至 API。"

def get_members_api():
    # res = requests.get(f"{API_BASE_URL}/members")
    # members = res.json()
    members = [
        {"姓名": "張三", "性別": "男", "電話": "0912345678", "小組": "青年團契"},
        {"姓名": "李四", "性別": "女", "電話": "0922333444", "小組": "婦女小組"},
    ]  # 模擬資料
    df = pd.DataFrame(members)
    return df

# --- Gradio UI ---
with gr.Blocks(title="教會會員管理系統 - 原型") as demo:
    gr.Markdown("# 🙏 教會會員管理系統 (Gradio 原型)")

    with gr.Tab("📋 會員管理"):
        with gr.Row():
            name = gr.Textbox(label="姓名")
            gender = gr.Dropdown(["男", "女"], label="性別")
            phone = gr.Textbox(label="電話")
            group = gr.Textbox(label="所屬小組")
        add_btn = gr.Button("➕ 新增會員")
        add_output = gr.Textbox(label="新增結果", interactive=False)
        add_btn.click(fn=add_member_api, inputs=[name, gender, phone, group], outputs=add_output)

        gr.Markdown("### 📖 所有會員清單")
        refresh_btn = gr.Button("🔄 重新整理會員資料")
        member_table = gr.Dataframe(headers=["姓名", "性別", "電話", "小組"], interactive=False)
        refresh_btn.click(fn=get_members_api, outputs=member_table)

    with gr.Tab("⛪ 出席管理"):
        gr.Markdown("（預留介面 - 可串接 /attendance API）")

    with gr.Tab("💰 奉獻管理"):
        gr.Markdown("（預留介面 - 可串接 /offerings API）")

    with gr.Tab("📊 報表匯出"):
        gr.Markdown("（預留介面 - 可下載 CSV / PDF）")

    with gr.Tab("⚙️ 系統設定"):
        gr.Markdown("（預留介面 - 教會基本資料與類別設定）")

demo.launch()
