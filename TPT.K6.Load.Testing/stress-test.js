import http from "k6/http";
import { sleep } from "k6";

export const options = {
  stages: [
    {
      duration: "10s",
      target: 500,
    },
    {
      duration: "1m",
      target: 500,
    },
    {
      duration: "10s",
      target: 0,
    },
  ],
};

// Performance testing
// Load testing
// Smoke testing
// --- Stress testing

export default function () {
  http.get("http://localhost:5389/weatherforecast");

  http.get("http://localhost:5206");

  http.get("http://localhost:5206/counter");

  http.get("http://localhost:5206/weather");
}
