using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_19cb-cc21098f")]
        public void Method_1012_19cb()
        {
            ii(0x1012_19cb, 5); push(0x4c);                             /* push 0x4c */
            ii(0x1012_19d0, 5); call(Definitions.sys_check_available_stack_size, 0x4_437d); /* call 0x10165d52 */
            ii(0x1012_19d5, 1); push(esi);                              /* push esi */
            ii(0x1012_19d6, 1); push(edi);                              /* push edi */
            ii(0x1012_19d7, 1); push(ebp);                              /* push ebp */
            ii(0x1012_19d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_19da, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1012_19e0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_19e3, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1012_19e6, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1012_19e9, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1012_19ec, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_19f0, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_19f3, 6); mov(al, memb[ds, eax + 0x101b_b061]);   /* mov al, [eax+0x101bb061] */
            ii(0x1012_19f9, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1012_19fc, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1012_1a01, 5); call(Definitions.sys_new, 0x4_43fa);    /* call 0x10165e00 */
            ii(0x1012_1a06, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1012_1a09, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_1a0c, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1012_1a0f, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1012_1a13, 2); if(jz(0x1012_1a3b, 0x26)) goto l_0x1012_1a3b; /* jz 0x10121a3b */
            ii(0x1012_1a15, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1012_1a19, 1); push(eax);                              /* push eax */
            ii(0x1012_1a1a, 4); movsx(ecx, memw[ss, ebp - 8]);          /* movsx ecx, word [ebp-0x8] */
            ii(0x1012_1a1e, 5); mov(ebx, 0x2b9);                        /* mov ebx, 0x2b9 */
            ii(0x1012_1a23, 5); mov(edx, 0x2ba);                        /* mov edx, 0x2ba */
            ii(0x1012_1a28, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_1a2b, 5); call(Definitions.my_ctor_c17, -0x5_3621); /* call 0x100ce40f */
            ii(0x1012_1a30, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1012_1a33, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1012_1a36, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1012_1a39, 2); jmp(0x1012_1a41, 6); goto l_0x1012_1a41; /* jmp 0x10121a41 */
        l_0x1012_1a3b:
            ii(0x1012_1a3b, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_1a3e, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x1012_1a41:
            ii(0x1012_1a41, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1012_1a45, 3); imul(edx, edx, 0x1c);                   /* imul edx, edx, 0x1c */
            ii(0x1012_1a48, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1012_1a4b, 6); mov(memd[ds, edx + 0x101b_b068], eax);  /* mov [edx+0x101bb068], eax */
            ii(0x1012_1a51, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_1a54, 3); mov(edx, memd[ds, eax + 0x29]);         /* mov edx, [eax+0x29] */
            ii(0x1012_1a57, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1a5b, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1a5e, 6); mov(eax, memd[ds, eax + 0x101b_b068]);  /* mov eax, [eax+0x101bb068] */
            ii(0x1012_1a64, 5); call(0x100c_e92d, -0x5_313c);           /* call 0x100ce92d */
            ii(0x1012_1a69, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1012_1a6e, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1a72, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1a75, 6); mov(eax, memd[ds, eax + 0x101b_b068]);  /* mov eax, [eax+0x101bb068] */
            ii(0x1012_1a7b, 5); call(0x100d_5194, -0x4_c8ec);           /* call 0x100d5194 */
            ii(0x1012_1a80, 4); cmp(memb[ss, ebp - 0x14], 0x39);        /* cmp byte [ebp-0x14], 0x39 */
            ii(0x1012_1a84, 2); if(jz(0x1012_1a8c, 6)) goto l_0x1012_1a8c; /* jz 0x10121a8c */
            ii(0x1012_1a86, 4); cmp(memb[ss, ebp - 0x14], 0x3a);        /* cmp byte [ebp-0x14], 0x3a */
            ii(0x1012_1a8a, 2); if(jnz(0x1012_1a8e, 2)) goto l_0x1012_1a8e; /* jnz 0x10121a8e */
        l_0x1012_1a8c:
            ii(0x1012_1a8c, 2); jmp(0x1012_1a94, 6); goto l_0x1012_1a94; /* jmp 0x10121a94 */
        l_0x1012_1a8e:
            ii(0x1012_1a8e, 4); cmp(memb[ss, ebp - 0x14], 0x3b);        /* cmp byte [ebp-0x14], 0x3b */
            ii(0x1012_1a92, 2); if(jnz(0x1012_1a96, 2)) goto l_0x1012_1a96; /* jnz 0x10121a96 */
        l_0x1012_1a94:
            ii(0x1012_1a94, 2); jmp(0x1012_1a9c, 6); goto l_0x1012_1a9c; /* jmp 0x10121a9c */
        l_0x1012_1a96:
            ii(0x1012_1a96, 4); cmp(memb[ss, ebp - 0x14], 0x40);        /* cmp byte [ebp-0x14], 0x40 */
            ii(0x1012_1a9a, 2); if(jnz(0x1012_1ad6, 0x3a)) goto l_0x1012_1ad6; /* jnz 0x10121ad6 */
        l_0x1012_1a9c:
            ii(0x1012_1a9c, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1aa0, 6); lea(edx, memd[ds, eax + 0x3ea]);        /* lea edx, [eax+0x3ea] */
            ii(0x1012_1aa6, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1aaa, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1aad, 6); mov(eax, memd[ds, eax + 0x101b_b068]);  /* mov eax, [eax+0x101bb068] */
            ii(0x1012_1ab3, 5); call(0x100d_5164, -0x4_c954);           /* call 0x100d5164 */
            ii(0x1012_1ab8, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1abc, 6); lea(edx, memd[ds, eax + 0x3ea]);        /* lea edx, [eax+0x3ea] */
            ii(0x1012_1ac2, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1ac6, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1ac9, 6); mov(eax, memd[ds, eax + 0x101b_b068]);  /* mov eax, [eax+0x101bb068] */
            ii(0x1012_1acf, 5); call(0x100d_5134, -0x4_c9a0);           /* call 0x100d5134 */
            ii(0x1012_1ad4, 2); jmp(0x1012_1b0e, 0x38); goto l_0x1012_1b0e; /* jmp 0x10121b0e */
        l_0x1012_1ad6:
            ii(0x1012_1ad6, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1ada, 6); lea(edx, memd[ds, eax + 0x73ea]);       /* lea edx, [eax+0x73ea] */
            ii(0x1012_1ae0, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1ae4, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1ae7, 6); mov(eax, memd[ds, eax + 0x101b_b068]);  /* mov eax, [eax+0x101bb068] */
            ii(0x1012_1aed, 5); call(0x100d_5164, -0x4_c98e);           /* call 0x100d5164 */
            ii(0x1012_1af2, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1af6, 6); lea(edx, memd[ds, eax + 0x73ea]);       /* lea edx, [eax+0x73ea] */
            ii(0x1012_1afc, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1b00, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1b03, 6); mov(eax, memd[ds, eax + 0x101b_b068]);  /* mov eax, [eax+0x101bb068] */
            ii(0x1012_1b09, 5); call(0x100d_5134, -0x4_c9da);           /* call 0x100d5134 */
        l_0x1012_1b0e:
            ii(0x1012_1b0e, 5); mov(edx, 0x4dd);                        /* mov edx, 0x4dd */
            ii(0x1012_1b13, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1b17, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1b1a, 6); mov(eax, memd[ds, eax + 0x101b_b068]);  /* mov eax, [eax+0x101bb068] */
            ii(0x1012_1b20, 5); call(0x100d_50d4, -0x4_ca51);           /* call 0x100d50d4 */
            ii(0x1012_1b25, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_1b28, 3); mov(edx, memd[ds, eax + 0x29]);         /* mov edx, [eax+0x29] */
            ii(0x1012_1b2b, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1b2f, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1b32, 6); mov(eax, memd[ds, eax + 0x101b_b068]);  /* mov eax, [eax+0x101bb068] */
            ii(0x1012_1b38, 5); call(0x100c_f85c, -0x5_22e1);           /* call 0x100cf85c */
            ii(0x1012_1b3d, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x1012_1b40, 5); call(0x1012_336c, 0x1827);              /* call 0x1012336c */
            ii(0x1012_1b45, 1); push(eax);                              /* push eax */
            ii(0x1012_1b46, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1012_1b4b, 1); push(eax);                              /* push eax */
            ii(0x1012_1b4c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_1b4e, 1); push(eax);                              /* push eax */
            ii(0x1012_1b4f, 5); mov(eax, 0x18);                         /* mov eax, 0x18 */
            ii(0x1012_1b54, 1); push(eax);                              /* push eax */
            ii(0x1012_1b55, 5); mov(eax, 0x9b);                         /* mov eax, 0x9b */
            ii(0x1012_1b5a, 1); push(eax);                              /* push eax */
            ii(0x1012_1b5b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_1b5e, 3); sub(eax, 2);                            /* sub eax, 0x2 */
            ii(0x1012_1b61, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1012_1b64, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_1b67, 5); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1012_1b6c, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_1b6f, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1012_1b73, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_1b76, 6); mov(edx, memd[ds, eax + 0x101b_b05d]);  /* mov edx, [eax+0x101bb05d] */
            ii(0x1012_1b7c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_1b7f, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1012_1b82, 5); call(0x100e_ab9d, -0x3_6fea);           /* call 0x100eab9d */
            ii(0x1012_1b87, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_1b89, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_1b8a, 1); pop(edi);                               /* pop edi */
            ii(0x1012_1b8b, 1); pop(esi);                               /* pop esi */
            ii(0x1012_1b8c, 1); ret();                                  /* ret */
        }
    }
}
