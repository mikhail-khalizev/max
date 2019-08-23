using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_504c-ad94850a")]
        public void Method_100d_504c()
        {
            ii(0x100d_504c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100d_5051, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0cfc); /* call 0x10165d52 */
            ii(0x100d_5056, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_5057, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_5058, 1); pushd(esi);                             /* push esi */
            ii(0x100d_5059, 1); pushd(edi);                             /* push edi */
            ii(0x100d_505a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_505b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_505d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100d_5063, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_5066, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_5069, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_506c, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x100d_506f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_5072, 3); cmp(dx, memw_a32[ds, eax]);             /* cmp dx, [eax] */
            ii(0x100d_5075, 2); if(jnzd(0x100d_507d, 0x6)) goto l_0x100d_507d; /* jnz 0x100d507d */
            ii(0x100d_5077, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_507b, 2); jmpd(0x100d_5081, 0x4); goto l_0x100d_5081; /* jmp 0x100d5081 */
        l_0x100d_507d:
            ii(0x100d_507d, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x100d_5081:
            ii(0x100d_5081, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100d_5084, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x100d_5087, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100d_508a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_508c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_508d, 1); popd(edi);                              /* pop edi */
            ii(0x100d_508e, 1); popd(esi);                              /* pop esi */
            ii(0x100d_508f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_5090, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_5091, 1); retd();                                 /* ret */
        }
    }
}
