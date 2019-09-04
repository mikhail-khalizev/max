using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_21cb-a8b899ff")]
        public void Method_1014_21cb()
        {
            ii(0x1014_21cb, 5); push(0x38);                             /* push 0x38 */
            ii(0x1014_21d0, 5); call(Definitions.sys_check_available_stack_size, 0x2_3b7d); /* call 0x10165d52 */
            ii(0x1014_21d5, 1); push(ebx);                              /* push ebx */
            ii(0x1014_21d6, 1); push(ecx);                              /* push ecx */
            ii(0x1014_21d7, 1); push(esi);                              /* push esi */
            ii(0x1014_21d8, 1); push(edi);                              /* push edi */
            ii(0x1014_21d9, 1); push(ebp);                              /* push ebp */
            ii(0x1014_21da, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_21dc, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_21e2, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_21e5, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_21e8, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1014_21ed, 5); call(Definitions.sys_new, 0x2_3c0e);    /* call 0x10165e00 */
            ii(0x1014_21f2, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1014_21f5, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_21f8, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1014_21fb, 4); cmp(memd[ss, ebp - 20], 0);             /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1014_21ff, 2); if(jz(0x1014_2217, 0x16)) goto l_0x1014_2217; /* jz 0x10142217 */
            ii(0x1014_2201, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_2204, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_2207, 5); call(Definitions.my_strobj_ctor_char_ptr, -0xa70); /* call 0x1014179c */
            ii(0x1014_220c, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1014_220f, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1014_2212, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_2215, 2); jmp(0x1014_221d, 6); goto l_0x1014_221d; /* jmp 0x1014221d */
        l_0x1014_2217:
            ii(0x1014_2217, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1014_221a, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
        l_0x1014_221d:
            ii(0x1014_221d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_2220, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1014_2223, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_2226, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_2228, 5); call(Definitions.my_string_release, 0x1ef); /* call 0x1014241c */
            ii(0x1014_222d, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1014_2230, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_2233, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x1014_2235, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_2238, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1014_223b, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1014_223e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_2240, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_2241, 1); pop(edi);                               /* pop edi */
            ii(0x1014_2242, 1); pop(esi);                               /* pop esi */
            ii(0x1014_2243, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_2244, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_2245, 1); ret();                                  /* ret */
        }
    }
}
