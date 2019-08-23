using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_0b54-1e7b99a6")]
        public void Method_100b_0b54()
        {
            ii(0x100b_0b54, 5); push(0x90);                             /* push 0x90 */
            ii(0x100b_0b59, 5); call(Definitions.sys_check_available_stack_size, 0xb_51f4); /* call 0x10165d52 */
            ii(0x100b_0b5e, 1); push(ebx);                              /* push ebx */
            ii(0x100b_0b5f, 1); push(ecx);                              /* push ecx */
            ii(0x100b_0b60, 1); push(esi);                              /* push esi */
            ii(0x100b_0b61, 1); push(edi);                              /* push edi */
            ii(0x100b_0b62, 1); push(ebp);                              /* push ebp */
            ii(0x100b_0b63, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_0b65, 6); sub(esp, 0x64);                         /* sub esp, 0x64 */
            ii(0x100b_0b6b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_0b6e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_0b71, 5); mov(edx, StringDefinitions.TransportUnits); /* mov edx, 0x101a0f5b */
            ii(0x100b_0b76, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0b79, 5); call(Definitions.sys_strcpy, 0xb_5351); /* call 0x10165ecf */
            ii(0x100b_0b7e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0b80, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0b83, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_0b86, 5); call(0x1013_ad11, 0x8_a186);            /* call 0x1013ad11 */
            ii(0x100b_0b8b, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0b8d, 2); if(jz(0x100b_0ba0, 0x11)) goto l_0x100b_0ba0; /* jz 0x100b0ba0 */
            ii(0x100b_0b8f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0b91, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0b94, 3); add(eax, 0x27);                         /* add eax, 0x27 */
            ii(0x100b_0b97, 5); call(0x1013_ad71, 0x8_a1d5);            /* call 0x1013ad71 */
            ii(0x100b_0b9c, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0b9e, 2); if(jnz(0x100b_0ba2, 0x2)) goto l_0x100b_0ba2; /* jnz 0x100b0ba2 */
        l_0x100b_0ba0:
            ii(0x100b_0ba0, 2); jmp(0x100b_0bcb, 0x29); goto l_0x100b_0bcb; /* jmp 0x100b0bcb */
        l_0x100b_0ba2:
            ii(0x100b_0ba2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0ba5, 3); mov(eax, memd[ds, eax + 0x11]);         /* mov eax, [eax+0x11] */
            ii(0x100b_0ba8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_0bab, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100b_0bae, 6); push(memd[ds, eax + 0x101c_81d7]);      /* push dword [eax+0x101c81d7] */
            ii(0x100b_0bb4, 5); mov(eax, StringDefinitions.TransportUnitsWaitingForS); /* mov eax, 0x101a0f6d */
            ii(0x100b_0bb9, 1); push(eax);                              /* push eax */
            ii(0x100b_0bba, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0bbd, 1); push(eax);                              /* push eax */
            ii(0x100b_0bbe, 5); call(Definitions.sys_sprintf, 0xb_533e); /* call 0x10165f01 */
            ii(0x100b_0bc3, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100b_0bc6, 5); jmp(0x100b_0d03, 0x138); goto l_0x100b_0d03; /* jmp 0x100b0d03 */
        l_0x100b_0bcb:
            ii(0x100b_0bcb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0bcd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0bd0, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0bd3, 5); call(0x1013_ad11, 0x8_a139);            /* call 0x1013ad11 */
            ii(0x100b_0bd8, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0bda, 2); if(jnz(0x100b_0bf0, 0x14)) goto l_0x100b_0bf0; /* jnz 0x100b0bf0 */
            ii(0x100b_0bdc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0bdf, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0be2, 5); call(0x1008_a520, -0x2_66c7);           /* call 0x1008a520 */
            ii(0x100b_0be7, 5); call(0x100b_7d68, 0x717c);              /* call 0x100b7d68 */
            ii(0x100b_0bec, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_0bee, 2); if(jnz(0x100b_0c02, 0x12)) goto l_0x100b_0c02; /* jnz 0x100b0c02 */
        l_0x100b_0bf0:
            ii(0x100b_0bf0, 5); mov(edx, StringDefinitions.DoingNothing); /* mov edx, 0x101a0f8e */
            ii(0x100b_0bf5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0bf8, 5); call(Definitions.sys_strcat, 0xb_5334); /* call 0x10165f31 */
            ii(0x100b_0bfd, 5); jmp(0x100b_0d03, 0x101); goto l_0x100b_0d03; /* jmp 0x100b0d03 */
        l_0x100b_0c02:
            ii(0x100b_0c02, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0c05, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0c08, 5); call(0x1008_a520, -0x2_66ed);           /* call 0x1008a520 */
            ii(0x100b_0c0d, 5); call(0x100b_7d68, 0x7156);              /* call 0x100b7d68 */
            ii(0x100b_0c12, 4); cmp(memb[ds, eax + 0x3d], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_0c16, 2); if(jz(0x100b_0c7b, 0x63)) goto l_0x100b_0c7b; /* jz 0x100b0c7b */
            ii(0x100b_0c18, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x100b_0c1b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0c1e, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0c21, 5); call(0x1008_a520, -0x2_6706);           /* call 0x1008a520 */
            ii(0x100b_0c26, 5); call(0x100b_7d68, 0x713d);              /* call 0x100b7d68 */
            ii(0x100b_0c2b, 5); call(0x1014_fa43, 0x9_ee13);            /* call 0x1014fa43 */
            ii(0x100b_0c30, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0c33, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0c36, 5); call(0x1008_a520, -0x2_671b);           /* call 0x1008a520 */
            ii(0x100b_0c3b, 5); call(0x100b_7d68, 0x7128);              /* call 0x100b7d68 */
            ii(0x100b_0c40, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x100b_0c43, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_0c46, 1); inc(eax);                               /* inc eax */
            ii(0x100b_0c47, 1); push(eax);                              /* push eax */
            ii(0x100b_0c48, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0c4b, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0c4e, 5); call(0x1008_a520, -0x2_6733);           /* call 0x1008a520 */
            ii(0x100b_0c53, 5); call(0x100b_7d68, 0x7110);              /* call 0x100b7d68 */
            ii(0x100b_0c58, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x100b_0c5b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_0c5e, 1); inc(eax);                               /* inc eax */
            ii(0x100b_0c5f, 1); push(eax);                              /* push eax */
            ii(0x100b_0c60, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100b_0c63, 1); push(eax);                              /* push eax */
            ii(0x100b_0c64, 5); mov(eax, StringDefinitions.TransportUnitsPickUpSAtII); /* mov eax, 0x101a0f9f */
            ii(0x100b_0c69, 1); push(eax);                              /* push eax */
            ii(0x100b_0c6a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0c6d, 1); push(eax);                              /* push eax */
            ii(0x100b_0c6e, 5); call(Definitions.sys_sprintf, 0xb_528e); /* call 0x10165f01 */
            ii(0x100b_0c73, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x100b_0c76, 5); jmp(0x100b_0d03, 0x88); goto l_0x100b_0d03; /* jmp 0x100b0d03 */
        l_0x100b_0c7b:
            ii(0x100b_0c7b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0c7d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0c80, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_0c83, 5); call(0x1013_ad71, 0x8_a0e9);            /* call 0x1013ad71 */
            ii(0x100b_0c88, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0c8a, 2); if(jz(0x100b_0ca1, 0x15)) goto l_0x100b_0ca1; /* jz 0x100b0ca1 */
            ii(0x100b_0c8c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0c8f, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_0c92, 5); call(0x1007_6574, -0x3_a723);           /* call 0x10076574 */
            ii(0x100b_0c97, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x100b_0c9a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_0c9d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_0c9f, 2); if(jg(0x100b_0ca3, 0x2)) goto l_0x100b_0ca3; /* jg 0x100b0ca3 */
        l_0x100b_0ca1:
            ii(0x100b_0ca1, 2); jmp(0x100b_0d03, 0x60); goto l_0x100b_0d03; /* jmp 0x100b0d03 */
        l_0x100b_0ca3:
            ii(0x100b_0ca3, 3); lea(edx, ebp - 0x5c);                   /* lea edx, [ebp-0x5c] */
            ii(0x100b_0ca6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0ca9, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0cac, 5); call(0x1008_a520, -0x2_6791);           /* call 0x1008a520 */
            ii(0x100b_0cb1, 5); call(0x100b_7d68, 0x70b2);              /* call 0x100b7d68 */
            ii(0x100b_0cb6, 5); call(0x1014_fa43, 0x9_ed88);            /* call 0x1014fa43 */
            ii(0x100b_0cbb, 3); lea(edx, ebp - 0x60);                   /* lea edx, [ebp-0x60] */
            ii(0x100b_0cbe, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0cc1, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0cc4, 5); call(0x1008_a520, -0x2_67a9);           /* call 0x1008a520 */
            ii(0x100b_0cc9, 5); call(0x100b_7da0, 0x70d2);              /* call 0x100b7da0 */
            ii(0x100b_0cce, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100b_0cd0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_0cd3, 1); inc(eax);                               /* inc eax */
            ii(0x100b_0cd4, 1); push(eax);                              /* push eax */
            ii(0x100b_0cd5, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x100b_0cd8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0cdb, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0cde, 5); call(0x1008_a520, -0x2_67c3);           /* call 0x1008a520 */
            ii(0x100b_0ce3, 5); call(0x100b_7da0, 0x70b8);              /* call 0x100b7da0 */
            ii(0x100b_0ce8, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100b_0ceb, 1); inc(eax);                               /* inc eax */
            ii(0x100b_0cec, 1); push(eax);                              /* push eax */
            ii(0x100b_0ced, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x100b_0cf0, 1); push(eax);                              /* push eax */
            ii(0x100b_0cf1, 5); mov(eax, StringDefinitions.TransportUnitsDropOffSAtII); /* mov eax, 0x101a0fc6 */
            ii(0x100b_0cf6, 1); push(eax);                              /* push eax */
            ii(0x100b_0cf7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0cfa, 1); push(eax);                              /* push eax */
            ii(0x100b_0cfb, 5); call(Definitions.sys_sprintf, 0xb_5201); /* call 0x10165f01 */
            ii(0x100b_0d00, 3); add(esp, 0x14);                         /* add esp, 0x14 */
        l_0x100b_0d03:
            ii(0x100b_0d03, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0d06, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_0d09, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_0d0c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_0d0e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_0d0f, 1); pop(edi);                               /* pop edi */
            ii(0x100b_0d10, 1); pop(esi);                               /* pop esi */
            ii(0x100b_0d11, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_0d12, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_0d13, 1); ret();                                  /* ret */
        }
    }
}
