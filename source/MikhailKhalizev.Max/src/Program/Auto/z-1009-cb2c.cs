using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_cb2c-ca365ec9")]
        public void Method_1009_cb2c()
        {
            ii(0x1009_cb2c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_cb31, 5); call(Definitions.sys_check_available_stack_size, 0xc_921c); /* call 0x10165d52 */
            ii(0x1009_cb36, 1); push(ecx);                              /* push ecx */
            ii(0x1009_cb37, 1); push(esi);                              /* push esi */
            ii(0x1009_cb38, 1); push(edi);                              /* push edi */
            ii(0x1009_cb39, 1); push(ebp);                              /* push ebp */
            ii(0x1009_cb3a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_cb3c, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1009_cb42, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_cb45, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1009_cb48, 3); mov(memb[ss, ebp - 0x4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1009_cb4b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_cb4d, 3); mov(bl, memb[ss, ebp - 0x4]);           /* mov bl, [ebp-0x4] */
            ii(0x1009_cb50, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_cb53, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_cb56, 5); call(0x1013_afb8, 0x9_e45d);            /* call 0x1013afb8 */
            ii(0x1009_cb5b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_cb5e, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_cb61, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_cb64, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_cb67, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_cb6a, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_cb6d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_cb6f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_cb70, 1); pop(edi);                               /* pop edi */
            ii(0x1009_cb71, 1); pop(esi);                               /* pop esi */
            ii(0x1009_cb72, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_cb73, 1); ret();                                  /* ret */
        }
    }
}
