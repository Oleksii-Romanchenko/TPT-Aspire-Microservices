import http from "k6/http";
import { sleep } from "k6";

export const options = {
  // A number specifying the number of VUs to run concurrently.
  vus: 1,
  // A string specifying the total duration of the test run.
  duration: "10s",
};

// Performance testing
// Load testing
// ---Smoke testing
// Stress testing

export default function () {
  http.get("http://localhost:5389/weatherforecast");
  sleep(1);
  http.get("http://localhost:5206");
  sleep(1);
  http.get("http://localhost:5206/counter");

  http.get("http://localhost:5206/weather");
}
