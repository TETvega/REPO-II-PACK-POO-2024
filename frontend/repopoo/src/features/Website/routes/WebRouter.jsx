import { Navigate, Route, Routes } from "react-router-dom";
import { HomePage } from "../pages/HomePage";

export const WebRouter = () => {
  return (
    <div>
      <div>
        <main className="flex-row">
          <div className="w-full">
            <Routes>
              <Route path="/home" element={<HomePage />} />
              <Route path="/*" element={<Navigate to={"/home"} />} />
            </Routes>
          </div>
        </main>
      </div>
    </div>
  );
};
