using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0a87-2751908d")]
        public void Method_100d_0a87()
        {
            ii(0x100d_0a87, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_0a8c, 5); call(Definitions.sys_check_available_stack_size, 0x9_52c1); /* call 0x10165d52 */
            ii(0x100d_0a91, 1); push(ecx);                              /* push ecx */
            ii(0x100d_0a92, 1); push(esi);                              /* push esi */
            ii(0x100d_0a93, 1); push(edi);                              /* push edi */
            ii(0x100d_0a94, 1); push(ebp);                              /* push ebp */
            ii(0x100d_0a95, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_0a97, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100d_0a9d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_0aa0, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100d_0aa3, 3); mov(memb[ss, ebp - 0x4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100d_0aa6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_0aa9, 5); call(0x100d_4dc8, 0x431a);              /* call 0x100d4dc8 */
            ii(0x100d_0aae, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_0ab1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_0ab4, 6); mov(memd[ds, eax], 0x101b_5cb8);        /* mov dword [eax], 0x101b5cb8 */
            ii(0x100d_0aba, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0abd, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_0ac0, 3); mov(memd[ds, edx + 0x4], eax);          /* mov [edx+0x4], eax */
            ii(0x100d_0ac3, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x100d_0ac6, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_0ac9, 3); mov(memb[ds, edx + 0x8], al);           /* mov [edx+0x8], al */
            ii(0x100d_0acc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_0acf, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_0ad2, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_0ad5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_0ad7, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_0ad8, 1); pop(edi);                               /* pop edi */
            ii(0x100d_0ad9, 1); pop(esi);                               /* pop esi */
            ii(0x100d_0ada, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_0adb, 1); ret();                                  /* ret */
        }
    }
}
