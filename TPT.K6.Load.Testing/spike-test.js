import http from "k6/http";

export const options = {
  stages: [
    {
      duration: "1m",
      target: 2000,
    },
    {
      duration: "2m",
      target: 100,
    },
  ],
};

// Performance testing
// Load testing
// Smoke testing
// --- Spike testing
// Stress testing

export default function () {
  http.get("http://localhost:5389/weatherforecast");

  http.get("http://localhost:5206");

  http.get("http://localhost:5206/counter");

  http.get("http://localhost:5206/weather");
}
