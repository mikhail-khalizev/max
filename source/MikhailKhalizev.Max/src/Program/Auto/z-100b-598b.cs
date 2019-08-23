using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_598b-adc21916")]
        public void Method_100b_598b()
        {
            ii(0x100b_598b, 5); push(0x38);                             /* push 0x38 */
            ii(0x100b_5990, 5); call(Definitions.sys_check_available_stack_size, 0xb_03bd); /* call 0x10165d52 */
            ii(0x100b_5995, 1); push(ebx);                              /* push ebx */
            ii(0x100b_5996, 1); push(ecx);                              /* push ecx */
            ii(0x100b_5997, 1); push(esi);                              /* push esi */
            ii(0x100b_5998, 1); push(edi);                              /* push edi */
            ii(0x100b_5999, 1); push(ebp);                              /* push ebp */
            ii(0x100b_599a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_599c, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100b_59a2, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_59a5, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_59a8, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_59ad, 5); call(0x1007_6338, -0x3_f67a);           /* call 0x10076338 */
            ii(0x100b_59b2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_59b4, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_59b7, 5); call(0x1007_64b8, -0x3_f504);           /* call 0x100764b8 */
            ii(0x100b_59bc, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_59bf, 5); call(Definitions.my_ctor_0x101b_4184, -0x3_eed4); /* call 0x10076af0 */
            ii(0x100b_59c4, 2); jmp(0x100b_59ce, 0x8); goto l_0x100b_59ce; /* jmp 0x100b59ce */
        l_0x100b_59c6:
            ii(0x100b_59c6, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_59c9, 5); call(0x1007_6bf8, -0x3_edd6);           /* call 0x10076bf8 */
        l_0x100b_59ce:
            ii(0x100b_59ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_59d0, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_59d3, 5); call(0x1013_ad71, 0x8_5399);            /* call 0x1013ad71 */
            ii(0x100b_59d8, 2); test(al, al);                           /* test al, al */
            ii(0x100b_59da, 6); if(jz(0x100b_5aac, 0xcc)) goto l_0x100b_5aac; /* jz 0x100b5aac */
            ii(0x100b_59e0, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_59e3, 5); call(0x1007_63a0, -0x3_f648);           /* call 0x100763a0 */
            ii(0x100b_59e8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_59ea, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100b_59ed, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_59f0, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x100b_59f3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_59f6, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_59f8, 6); if(jnz(0x100b_5aa7, 0xa9)) goto l_0x100b_5aa7; /* jnz 0x100b5aa7 */
            ii(0x100b_59fe, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100b_5a01, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_5a04, 5); call(0x1007_63a0, -0x3_f669);           /* call 0x100763a0 */
            ii(0x100b_5a09, 5); call(0x1015_2532, 0x9_cb24);            /* call 0x10152532 */
            ii(0x100b_5a0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5a10, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100b_5a13, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100b_5a16, 5); call(0x1007_6e7c, -0x3_eb9f);           /* call 0x10076e7c */
            ii(0x100b_5a1b, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100b_5a1e, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x100b_5a24, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_5a27, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100b_5a2a, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100b_5a2d, 5); call(Definitions.my_min, -0x2_c2ae);    /* call 0x10089784 */
            ii(0x100b_5a32, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_5a35, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5a37, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_5a3a, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100b_5a3d, 5); call(0x1007_6e7c, -0x3_ebc6);           /* call 0x10076e7c */
            ii(0x100b_5a42, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100b_5a45, 6); mov(edx, memd[ds, 0x101c_8172]);        /* mov edx, [0x101c8172] */
            ii(0x100b_5a4b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_5a4e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_5a51, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100b_5a54, 5); call(Definitions.my_min, -0x2_c2d5);    /* call 0x10089784 */
            ii(0x100b_5a59, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_5a5c, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100b_5a5f, 4); mov(memw[ss, ebp - 0x10], ax);          /* mov [ebp-0x10], ax */
            ii(0x100b_5a63, 2); jmp(0x100b_5a6c, 0x7); goto l_0x100b_5a6c; /* jmp 0x100b5a6c */
        l_0x100b_5a65:
            ii(0x100b_5a65, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_5a68, 4); inc(memw[ss, ebp - 0x10]);              /* inc word [ebp-0x10] */
        l_0x100b_5a6c:
            ii(0x100b_5a6c, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100b_5a70, 3); cmp(eax, memd[ss, ebp - 0x18]);         /* cmp eax, [ebp-0x18] */
            ii(0x100b_5a73, 2); if(jge(0x100b_5aa7, 0x32)) goto l_0x100b_5aa7; /* jge 0x100b5aa7 */
            ii(0x100b_5a75, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_5a78, 4); mov(memw[ss, ebp - 0xe], ax);           /* mov [ebp-0xe], ax */
            ii(0x100b_5a7c, 2); jmp(0x100b_5a85, 0x7); goto l_0x100b_5a85; /* jmp 0x100b5a85 */
        l_0x100b_5a7e:
            ii(0x100b_5a7e, 3); mov(eax, memd[ss, ebp - 0xe]);          /* mov eax, [ebp-0xe] */
            ii(0x100b_5a81, 4); inc(memw[ss, ebp - 0xe]);               /* inc word [ebp-0xe] */
        l_0x100b_5a85:
            ii(0x100b_5a85, 4); movsx(eax, memw[ss, ebp - 0xe]);        /* movsx eax, word [ebp-0xe] */
            ii(0x100b_5a89, 3); cmp(eax, memd[ss, ebp - 0x14]);         /* cmp eax, [ebp-0x14] */
            ii(0x100b_5a8c, 2); if(jge(0x100b_5aa5, 0x17)) goto l_0x100b_5aa5; /* jge 0x100b5aa5 */
            ii(0x100b_5a8e, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100b_5a92, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_5a95, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x100b_5a98, 4); movsx(edx, memw[ss, ebp - 0xe]);        /* movsx edx, word [ebp-0xe] */
            ii(0x100b_5a9c, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100b_5a9e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_5aa0, 3); mov(memb[ds, eax], 0x1);                /* mov byte [eax], 0x1 */
            ii(0x100b_5aa3, 2); jmp(0x100b_5a7e, -0x27); goto l_0x100b_5a7e; /* jmp 0x100b5a7e */
        l_0x100b_5aa5:
            ii(0x100b_5aa5, 2); jmp(0x100b_5a65, -0x42); goto l_0x100b_5a65; /* jmp 0x100b5a65 */
        l_0x100b_5aa7:
            ii(0x100b_5aa7, 5); jmp(0x100b_59c6, -0xe6); goto l_0x100b_59c6; /* jmp 0x100b59c6 */
        l_0x100b_5aac:
            ii(0x100b_5aac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5aae, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_5ab1, 5); call(0x1007_5f6c, -0x3_fb4a);           /* call 0x10075f6c */
            ii(0x100b_5ab6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_5ab8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_5ab9, 1); pop(edi);                               /* pop edi */
            ii(0x100b_5aba, 1); pop(esi);                               /* pop esi */
            ii(0x100b_5abb, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_5abc, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_5abd, 1); ret();                                  /* ret */
        }
    }
}
