using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_6a6d-ad6f1de9")]
        public void Method_1014_6a6d()
        {
            ii(0x1014_6a6d, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1014_6a72, 5); call(Definitions.sys_check_available_stack_size, 0x1_f2db); /* call 0x10165d52 */
            ii(0x1014_6a77, 1); push(ebx);                              /* push ebx */
            ii(0x1014_6a78, 1); push(ecx);                              /* push ecx */
            ii(0x1014_6a79, 1); push(edx);                              /* push edx */
            ii(0x1014_6a7a, 1); push(esi);                              /* push esi */
            ii(0x1014_6a7b, 1); push(edi);                              /* push edi */
            ii(0x1014_6a7c, 1); push(ebp);                              /* push ebp */
            ii(0x1014_6a7d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_6a7f, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1014_6a85, 4); or(memb[ss, ebp - 0x4], 0x1);           /* or byte [ebp-0x4], 0x1 */
            ii(0x1014_6a89, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_6a8c, 5); call(Definitions.my_string_ctor, -0x4fa9); /* call 0x10141ae8 */
            ii(0x1014_6a91, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_6a94, 4); and(memb[ss, ebp - 0x4], -0x2 /* 0xfe */); /* and byte [ebp-0x4], 0xfe */
            ii(0x1014_6a98, 3); lea(eax, ebp + 0x24);                   /* lea eax, [ebp+0x24] */
            ii(0x1014_6a9b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_6a9e, 3); lea(ecx, ebp - 0xc);                    /* lea ecx, [ebp-0xc] */
            ii(0x1014_6aa1, 3); mov(ebx, memd[ss, ebp + 0x20]);         /* mov ebx, [ebp+0x20] */
            ii(0x1014_6aa4, 5); mov(edx, 0x12c);                        /* mov edx, 0x12c */
            ii(0x1014_6aa9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_6aac, 5); call(0x1014_20d7, -0x49da);             /* call 0x101420d7 */
            ii(0x1014_6ab1, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_6ab8, 1); int3();                                 /* int3 */
            ii(0x1014_6ab9, 5); call(0x100c_aa00, -0x7_c0be);           /* call 0x100caa00 */
            ii(0x1014_6abe, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_6ac3, 1); push(eax);                              /* push eax */
            ii(0x1014_6ac4, 5); call(0x100c_aa20, -0x7_c0a9);           /* call 0x100caa20 */
            ii(0x1014_6ac9, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_6acc, 5); mov(edi, 0x1);                          /* mov edi, 0x1 */
            ii(0x1014_6ad1, 7); mov(memd[ss, ebp - 0x1c], 0x2);         /* mov dword [ebp-0x1c], 0x2 */
            ii(0x1014_6ad8, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1014_6adb, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1014_6ade, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_6ae1, 1); push(eax);                              /* push eax */
            ii(0x1014_6ae2, 3); mov(ecx, memd[ss, ebp + 0x1c]);         /* mov ecx, [ebp+0x1c] */
            ii(0x1014_6ae5, 3); mov(ecx, memd[ds, ecx + 0x16]);         /* mov ecx, [ecx+0x16] */
            ii(0x1014_6ae8, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1014_6aeb, 3); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x1014_6aee, 5); call(Definitions.my_strobj_c_str_v2, -0xb_d32b); /* call 0x100897c8 */
            ii(0x1014_6af3, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_6af5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_6af8, 5); call(Definitions.my_strobj_c_str_v2, -0xb_d335); /* call 0x100897c8 */
            ii(0x1014_6afd, 3); lea(esi, ebp - 0x8);                    /* lea esi, [ebp-0x8] */
            ii(0x1014_6b00, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_6b02, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1014_6b04, 5); call(0x1014_5056, -0x1ab3);             /* call 0x10145056 */
            ii(0x1014_6b09, 5); call(Definitions.my_strobj_c_str_v2, -0xb_d346); /* call 0x100897c8 */
            ii(0x1014_6b0e, 3); mov(ecx, memd[ss, ebp - 0x18]);         /* mov ecx, [ebp-0x18] */
            ii(0x1014_6b11, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1014_6b13, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1014_6b16, 5); call(0x1011_5d23, -0x3_0df8);           /* call 0x10115d23 */
            ii(0x1014_6b1b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6b1d, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_6b20, 5); call(Definitions.my_string_dtor, -0x4ffb); /* call 0x10141b2a */
            ii(0x1014_6b25, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6b27, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_6b2a, 5); call(Definitions.my_string_dtor, -0x5005); /* call 0x10141b2a */
            ii(0x1014_6b2f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_6b31, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_6b32, 1); pop(edi);                               /* pop edi */
            ii(0x1014_6b33, 1); pop(esi);                               /* pop esi */
            ii(0x1014_6b34, 1); pop(edx);                               /* pop edx */
            ii(0x1014_6b35, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_6b36, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_6b37, 1); ret();                                  /* ret */
        }
    }
}
