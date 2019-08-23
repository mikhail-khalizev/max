using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9e06-a66f4ea0")]
        public void Method_100a_9e06()
        {
            ii(0x100a_9e06, 5); push(0x34);                             /* push 0x34 */
            ii(0x100a_9e0b, 5); call(Definitions.sys_check_available_stack_size, 0xb_bf42); /* call 0x10165d52 */
            ii(0x100a_9e10, 1); push(ebx);                              /* push ebx */
            ii(0x100a_9e11, 1); push(ecx);                              /* push ecx */
            ii(0x100a_9e12, 1); push(edx);                              /* push edx */
            ii(0x100a_9e13, 1); push(esi);                              /* push esi */
            ii(0x100a_9e14, 1); push(edi);                              /* push edi */
            ii(0x100a_9e15, 1); push(ebp);                              /* push ebp */
            ii(0x100a_9e16, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_9e18, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100a_9e1e, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_9e21, 5); mov(eax, 0x2d);                         /* mov eax, 0x2d */
            ii(0x100a_9e26, 5); call(Definitions.sys_new, 0xb_bfd5);    /* call 0x10165e00 */
            ii(0x100a_9e2b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_9e2e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_9e31, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_9e34, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100a_9e38, 2); if(jz(0x100a_9e50, 0x16)) goto l_0x100a_9e50; /* jz 0x100a9e50 */
            ii(0x100a_9e3a, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_9e3d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_9e40, 5); call(0x1009_f304, -0xab41);             /* call 0x1009f304 */
            ii(0x100a_9e45, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_9e48, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_9e4b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_9e4e, 2); jmp(0x100a_9e56, 0x6); goto l_0x100a_9e56; /* jmp 0x100a9e56 */
        l_0x100a_9e50:
            ii(0x100a_9e50, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_9e53, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
        l_0x100a_9e56:
            ii(0x100a_9e56, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_9e59, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_9e5c, 5); call(0x1008_b060, -0x1_ee01);           /* call 0x1008b060 */
            ii(0x100a_9e61, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_9e64, 5); call(0x1008_af84, -0x1_eee5);           /* call 0x1008af84 */
            ii(0x100a_9e69, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_9e6b, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_9e70, 5); call(0x100a_4d50, -0x5125);             /* call 0x100a4d50 */
            ii(0x100a_9e75, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_9e77, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_9e7a, 5); call(0x1008_8b7c, -0x2_1303);           /* call 0x10088b7c */
            ii(0x100a_9e7f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_9e81, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_9e82, 1); pop(edi);                               /* pop edi */
            ii(0x100a_9e83, 1); pop(esi);                               /* pop esi */
            ii(0x100a_9e84, 1); pop(edx);                               /* pop edx */
            ii(0x100a_9e85, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_9e86, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_9e87, 1); ret();                                  /* ret */
        }
    }
}
