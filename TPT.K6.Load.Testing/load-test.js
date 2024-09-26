import http from "k6/http";
import { sleep } from "k6";

export const options = {
  stages: [
    {
      duration: "50s",
      target: 100,
    },
    {
      duration: "2m",
      target: 100,
    },
    {
      duration: "50s",
      target: 0,
    },
  ],
};
// Performance testing
// --- Load testing
// Smoke testing
// stress testing

export default function () {
  http.get("http://localhost:5389/weatherforecast");

  http.get("http://localhost:5206");

  http.get("http://localhost:5206/counter");

  http.get("http://localhost:5206/weather");
}
