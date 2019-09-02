using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_aa72-817330e6")]
        public void Method_1015_aa72()
        {
            ii(0x1015_aa72, 5); push(0x20);                             /* push 0x20 */
            ii(0x1015_aa77, 5); call(Definitions.sys_check_available_stack_size, 0xb2d6); /* call 0x10165d52 */
            ii(0x1015_aa7c, 1); push(ebx);                              /* push ebx */
            ii(0x1015_aa7d, 1); push(ecx);                              /* push ecx */
            ii(0x1015_aa7e, 1); push(edx);                              /* push edx */
            ii(0x1015_aa7f, 1); push(esi);                              /* push esi */
            ii(0x1015_aa80, 1); push(edi);                              /* push edi */
            ii(0x1015_aa81, 1); push(ebp);                              /* push ebp */
            ii(0x1015_aa82, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_aa84, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1015_aa8a, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x1015_aa91, 2); jmp(0x1015_aa99, 6); goto l_0x1015_aa99; /* jmp 0x1015aa99 */
        l_0x1015_aa93:
            ii(0x1015_aa93, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_aa96, 3); inc(memd[ss, ebp - 4]);                 /* inc dword [ebp-0x4] */
        l_0x1015_aa99:
            ii(0x1015_aa99, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_aa9d, 3); cmp(eax, 5);                            /* cmp eax, 0x5 */
            ii(0x1015_aaa0, 2); if(jge(0x1015_aab7, 0x15)) goto l_0x1015_aab7; /* jge 0x1015aab7 */
            ii(0x1015_aaa2, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_aaa6, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1015_aaa9, 5); mov(eax, 0x101c_9480);                  /* mov eax, 0x101c9480 */
            ii(0x1015_aaae, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_aab0, 5); call(0x1013_a6f4, -0x2_03c1);           /* call 0x1013a6f4 */
            ii(0x1015_aab5, 2); jmp(0x1015_aa93, -0x24); goto l_0x1015_aa93; /* jmp 0x1015aa93 */
        l_0x1015_aab7:
            ii(0x1015_aab7, 5); mov(eax, 0x101c_81b4);                  /* mov eax, 0x101c81b4 */
            ii(0x1015_aabc, 5); call(0x1013_a6f4, -0x2_03cd);           /* call 0x1013a6f4 */
            ii(0x1015_aac1, 9); mov(memw[ds, 0x101c_8168], 0);          /* mov word [0x101c8168], 0x0 */
            ii(0x1015_aaca, 10); mov(memd[ds, 0x101c_816c], 0);         /* mov dword [0x101c816c], 0x0 */
            ii(0x1015_aad4, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x1015_aadb, 2); jmp(0x1015_aae3, 6); goto l_0x1015_aae3; /* jmp 0x1015aae3 */
        l_0x1015_aadd:
            ii(0x1015_aadd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_aae0, 3); inc(memd[ss, ebp - 4]);                 /* inc dword [ebp-0x4] */
        l_0x1015_aae3:
            ii(0x1015_aae3, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_aae7, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1015_aaea, 2); if(jge(0x1015_ab2e, 0x42)) goto l_0x1015_ab2e; /* jge 0x1015ab2e */
            ii(0x1015_aaec, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_aaf0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_aaf6, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1015_aafc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_ab01, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_ab03, 2); if(jz(0x1015_ab1f, 0x1a)) goto l_0x1015_ab1f; /* jz 0x1015ab1f */
            ii(0x1015_ab05, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_ab09, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_ab0f, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1015_ab15, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_ab1a, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1015_ab1d, 2); if(jnz(0x1015_ab21, 2)) goto l_0x1015_ab21; /* jnz 0x1015ab21 */
        l_0x1015_ab1f:
            ii(0x1015_ab1f, 2); jmp(0x1015_ab2c, 0xb); goto l_0x1015_ab2c; /* jmp 0x1015ab2c */
        l_0x1015_ab21:
            ii(0x1015_ab21, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_ab24, 6); mov(memw[ds, 0x101c_8168], ax);         /* mov [0x101c8168], ax */
            ii(0x1015_ab2a, 2); jmp(0x1015_ab2e, 2); goto l_0x1015_ab2e; /* jmp 0x1015ab2e */
        l_0x1015_ab2c:
            ii(0x1015_ab2c, 2); jmp(0x1015_aadd, -0x51); goto l_0x1015_aadd; /* jmp 0x1015aadd */
        l_0x1015_ab2e:
            ii(0x1015_ab2e, 10); mov(memd[ds, 0x101c_afcc], 0x1015_8bbb); /* mov dword [0x101cafcc], 0x10158bbb */
            ii(0x1015_ab38, 10); mov(memd[ds, 0x101c_afd0], 0x1015_7c2b); /* mov dword [0x101cafd0], 0x10157c2b */
            ii(0x1015_ab42, 5); mov(edi, 0x101c_afd4);                  /* mov edi, 0x101cafd4 */
            ii(0x1015_ab47, 5); mov(esi, 0x101c_afcc);                  /* mov esi, 0x101cafcc */
            ii(0x1015_ab4c, 1); movsd();                                /* movsd */
            ii(0x1015_ab4d, 1); movsd();                                /* movsd */
            ii(0x1015_ab4e, 10); mov(memd[ds, 0x101c_afd8], 0x1015_7c72); /* mov dword [0x101cafd8], 0x10157c72 */
            ii(0x1015_ab58, 5); mov(edi, 0x101c_afdc);                  /* mov edi, 0x101cafdc */
            ii(0x1015_ab5d, 5); mov(esi, 0x101c_afd4);                  /* mov esi, 0x101cafd4 */
            ii(0x1015_ab62, 1); movsd();                                /* movsd */
            ii(0x1015_ab63, 1); movsd();                                /* movsd */
            ii(0x1015_ab64, 10); mov(memd[ds, 0x101c_afdc], 0x1015_8e0a); /* mov dword [0x101cafdc], 0x10158e0a */
            ii(0x1015_ab6e, 5); mov(edi, 0x101c_b044);                  /* mov edi, 0x101cb044 */
            ii(0x1015_ab73, 5); mov(esi, 0x101c_afcc);                  /* mov esi, 0x101cafcc */
            ii(0x1015_ab78, 1); movsd();                                /* movsd */
            ii(0x1015_ab79, 1); movsd();                                /* movsd */
            ii(0x1015_ab7a, 10); mov(memd[ds, 0x101c_b044], 0x1015_9acd); /* mov dword [0x101cb044], 0x10159acd */
            ii(0x1015_ab84, 5); mov(edi, 0x101c_b054);                  /* mov edi, 0x101cb054 */
            ii(0x1015_ab89, 5); mov(esi, 0x101c_afcc);                  /* mov esi, 0x101cafcc */
            ii(0x1015_ab8e, 1); movsd();                                /* movsd */
            ii(0x1015_ab8f, 1); movsd();                                /* movsd */
            ii(0x1015_ab90, 10); mov(memd[ds, 0x101c_b054], 0x1015_9e2a); /* mov dword [0x101cb054], 0x10159e2a */
            ii(0x1015_ab9a, 5); mov(edi, 0x101c_b064);                  /* mov edi, 0x101cb064 */
            ii(0x1015_ab9f, 5); mov(esi, 0x101c_afcc);                  /* mov esi, 0x101cafcc */
            ii(0x1015_aba4, 1); movsd();                                /* movsd */
            ii(0x1015_aba5, 1); movsd();                                /* movsd */
            ii(0x1015_aba6, 10); mov(memd[ds, 0x101c_b064], 0x1015_9e99); /* mov dword [0x101cb064], 0x10159e99 */
            ii(0x1015_abb0, 5); mov(edi, 0x101c_b014);                  /* mov edi, 0x101cb014 */
            ii(0x1015_abb5, 5); mov(esi, 0x101c_afcc);                  /* mov esi, 0x101cafcc */
            ii(0x1015_abba, 1); movsd();                                /* movsd */
            ii(0x1015_abbb, 1); movsd();                                /* movsd */
            ii(0x1015_abbc, 10); mov(memd[ds, 0x101c_b014], 0x1015_8bbb); /* mov dword [0x101cb014], 0x10158bbb */
            ii(0x1015_abc6, 5); mov(edi, 0x101c_b01c);                  /* mov edi, 0x101cb01c */
            ii(0x1015_abcb, 5); mov(esi, 0x101c_afcc);                  /* mov esi, 0x101cafcc */
            ii(0x1015_abd0, 1); movsd();                                /* movsd */
            ii(0x1015_abd1, 1); movsd();                                /* movsd */
            ii(0x1015_abd2, 10); mov(memd[ds, 0x101c_b01c], 0x1015_91a8); /* mov dword [0x101cb01c], 0x101591a8 */
            ii(0x1015_abdc, 5); mov(edi, 0x101c_b03c);                  /* mov edi, 0x101cb03c */
            ii(0x1015_abe1, 5); mov(esi, 0x101c_afcc);                  /* mov esi, 0x101cafcc */
            ii(0x1015_abe6, 1); movsd();                                /* movsd */
            ii(0x1015_abe7, 1); movsd();                                /* movsd */
            ii(0x1015_abe8, 10); mov(memd[ds, 0x101c_b03c], 0x1015_95b7); /* mov dword [0x101cb03c], 0x101595b7 */
            ii(0x1015_abf2, 10); mov(memd[ds, 0x101c_b040], 0x1015_7c72); /* mov dword [0x101cb040], 0x10157c72 */
            ii(0x1015_abfc, 5); mov(edi, 0x101c_afe4);                  /* mov edi, 0x101cafe4 */
            ii(0x1015_ac01, 5); mov(esi, 0x101c_afd4);                  /* mov esi, 0x101cafd4 */
            ii(0x1015_ac06, 1); movsd();                                /* movsd */
            ii(0x1015_ac07, 1); movsd();                                /* movsd */
            ii(0x1015_ac08, 10); mov(memd[ds, 0x101c_afe4], 0x1015_8eb9); /* mov dword [0x101cafe4], 0x10158eb9 */
            ii(0x1015_ac12, 5); mov(edi, 0x101c_aff4);                  /* mov edi, 0x101caff4 */
            ii(0x1015_ac17, 5); mov(esi, 0x101c_afd4);                  /* mov esi, 0x101cafd4 */
            ii(0x1015_ac1c, 1); movsd();                                /* movsd */
            ii(0x1015_ac1d, 1); movsd();                                /* movsd */
            ii(0x1015_ac1e, 10); mov(memd[ds, 0x101c_aff4], 0x1015_8f57); /* mov dword [0x101caff4], 0x10158f57 */
            ii(0x1015_ac28, 5); mov(edi, 0x101c_affc);                  /* mov edi, 0x101caffc */
            ii(0x1015_ac2d, 5); mov(esi, 0x101c_afd4);                  /* mov esi, 0x101cafd4 */
            ii(0x1015_ac32, 1); movsd();                                /* movsd */
            ii(0x1015_ac33, 1); movsd();                                /* movsd */
            ii(0x1015_ac34, 10); mov(memd[ds, 0x101c_affc], 0x1015_90fc); /* mov dword [0x101caffc], 0x101590fc */
            ii(0x1015_ac3e, 5); mov(edi, 0x101c_b004);                  /* mov edi, 0x101cb004 */
            ii(0x1015_ac43, 5); mov(esi, 0x101c_afd4);                  /* mov esi, 0x101cafd4 */
            ii(0x1015_ac48, 1); movsd();                                /* movsd */
            ii(0x1015_ac49, 1); movsd();                                /* movsd */
            ii(0x1015_ac4a, 10); mov(memd[ds, 0x101c_b004], 0x1015_91a8); /* mov dword [0x101cb004], 0x101591a8 */
            ii(0x1015_ac54, 5); mov(edi, 0x101c_b00c);                  /* mov edi, 0x101cb00c */
            ii(0x1015_ac59, 5); mov(esi, 0x101c_afd4);                  /* mov esi, 0x101cafd4 */
            ii(0x1015_ac5e, 1); movsd();                                /* movsd */
            ii(0x1015_ac5f, 1); movsd();                                /* movsd */
            ii(0x1015_ac60, 10); mov(memd[ds, 0x101c_b00c], 0x1015_9226); /* mov dword [0x101cb00c], 0x10159226 */
            ii(0x1015_ac6a, 5); mov(edi, 0x101c_b034);                  /* mov edi, 0x101cb034 */
            ii(0x1015_ac6f, 5); mov(esi, 0x101c_afd4);                  /* mov esi, 0x101cafd4 */
            ii(0x1015_ac74, 1); movsd();                                /* movsd */
            ii(0x1015_ac75, 1); movsd();                                /* movsd */
            ii(0x1015_ac76, 10); mov(memd[ds, 0x101c_b034], 0x1015_9304); /* mov dword [0x101cb034], 0x10159304 */
            ii(0x1015_ac80, 10); mov(memd[ds, 0x101c_b038], 0x1015_938e); /* mov dword [0x101cb038], 0x1015938e */
            ii(0x1015_ac8a, 5); mov(edi, 0x101c_b06c);                  /* mov edi, 0x101cb06c */
            ii(0x1015_ac8f, 5); mov(esi, 0x101c_afd4);                  /* mov esi, 0x101cafd4 */
            ii(0x1015_ac94, 1); movsd();                                /* movsd */
            ii(0x1015_ac95, 1); movsd();                                /* movsd */
            ii(0x1015_ac96, 10); mov(memd[ds, 0x101c_b06c], 0x1015_a08a); /* mov dword [0x101cb06c], 0x1015a08a */
            ii(0x1015_aca0, 5); mov(edi, 0x101c_b074);                  /* mov edi, 0x101cb074 */
            ii(0x1015_aca5, 5); mov(esi, 0x101c_afd4);                  /* mov esi, 0x101cafd4 */
            ii(0x1015_acaa, 1); movsd();                                /* movsd */
            ii(0x1015_acab, 1); movsd();                                /* movsd */
            ii(0x1015_acac, 10); mov(memd[ds, 0x101c_b074], 0x1015_a981); /* mov dword [0x101cb074], 0x1015a981 */
            ii(0x1015_acb6, 5); mov(edi, 0x101c_b02c);                  /* mov edi, 0x101cb02c */
            ii(0x1015_acbb, 5); mov(esi, 0x101c_b044);                  /* mov esi, 0x101cb044 */
            ii(0x1015_acc0, 1); movsd();                                /* movsd */
            ii(0x1015_acc1, 1); movsd();                                /* movsd */
            ii(0x1015_acc2, 10); mov(memd[ds, 0x101c_b02c], 0x1015_9c9b); /* mov dword [0x101cb02c], 0x10159c9b */
            ii(0x1015_accc, 5); mov(edi, 0x101c_b04c);                  /* mov edi, 0x101cb04c */
            ii(0x1015_acd1, 5); mov(esi, 0x101c_b044);                  /* mov esi, 0x101cb044 */
            ii(0x1015_acd6, 1); movsd();                                /* movsd */
            ii(0x1015_acd7, 1); movsd();                                /* movsd */
            ii(0x1015_acd8, 10); mov(memd[ds, 0x101c_b04c], 0x1015_9da1); /* mov dword [0x101cb04c], 0x10159da1 */
            ii(0x1015_ace2, 5); mov(edi, 0x101c_b07c);                  /* mov edi, 0x101cb07c */
            ii(0x1015_ace7, 5); mov(esi, 0x101c_afcc);                  /* mov esi, 0x101cafcc */
            ii(0x1015_acec, 1); movsd();                                /* movsd */
            ii(0x1015_aced, 1); movsd();                                /* movsd */
            ii(0x1015_acee, 10); mov(memd[ds, 0x101c_b07c], 0x1015_9a44); /* mov dword [0x101cb07c], 0x10159a44 */
            ii(0x1015_acf8, 5); mov(edi, 0x101c_b05c);                  /* mov edi, 0x101cb05c */
            ii(0x1015_acfd, 5); mov(esi, 0x101c_afcc);                  /* mov esi, 0x101cafcc */
            ii(0x1015_ad02, 1); movsd();                                /* movsd */
            ii(0x1015_ad03, 1); movsd();                                /* movsd */
            ii(0x1015_ad04, 10); mov(memd[ds, 0x101c_b05c], 0x1015_9943); /* mov dword [0x101cb05c], 0x10159943 */
            ii(0x1015_ad0e, 5); mov(edi, 0x101c_afec);                  /* mov edi, 0x101cafec */
            ii(0x1015_ad13, 5); mov(esi, 0x101c_afd4);                  /* mov esi, 0x101cafd4 */
            ii(0x1015_ad18, 1); movsd();                                /* movsd */
            ii(0x1015_ad19, 1); movsd();                                /* movsd */
            ii(0x1015_ad1a, 10); mov(memd[ds, 0x101c_afec], 0x1015_9840); /* mov dword [0x101cafec], 0x10159840 */
            ii(0x1015_ad24, 5); mov(edi, 0x101c_b024);                  /* mov edi, 0x101cb024 */
            ii(0x1015_ad29, 5); mov(esi, 0x101c_afd4);                  /* mov esi, 0x101cafd4 */
            ii(0x1015_ad2e, 1); movsd();                                /* movsd */
            ii(0x1015_ad2f, 1); movsd();                                /* movsd */
            ii(0x1015_ad30, 10); mov(memd[ds, 0x101c_b024], 0x1015_9c9b); /* mov dword [0x101cb024], 0x10159c9b */
            ii(0x1015_ad3a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_ad3c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_ad3d, 1); pop(edi);                               /* pop edi */
            ii(0x1015_ad3e, 1); pop(esi);                               /* pop esi */
            ii(0x1015_ad3f, 1); pop(edx);                               /* pop edx */
            ii(0x1015_ad40, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_ad41, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_ad42, 1); ret();                                  /* ret */
        }
    }
}
