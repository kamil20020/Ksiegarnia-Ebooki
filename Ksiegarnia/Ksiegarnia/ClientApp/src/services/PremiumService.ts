﻿import axios from "axios";

export interface BuyPremiumRequest {
  isActive: boolean;
  userId: string;
  buyDate: string;
  days: number;
}

class PremiumService {
  private api = "https://localhost:7270/Premium";

  buyPremium(request: BuyPremiumRequest) {
    return axios.post(`${this.api}/buy`, request, {
      params: { currency: "PLN" },
    });
  }

  checkPremium(userId: string) {
    return axios.get(`${this.api}/${userId}/Check`);
  }
}

export default new PremiumService();
