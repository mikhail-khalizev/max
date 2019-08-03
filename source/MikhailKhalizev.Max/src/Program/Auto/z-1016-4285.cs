using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9e199f3a-8dca-43db-97ec-bfeb4b99e46c")]
        public void Method_1016_4285()
        {
            ii(0x1016_4285, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1016_428a, 5); calld(Definitions.sys_check_available_stack_size, 0x1ac3); /* call 0x10165d52 */
            ii(0x1016_428f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_4290, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_4291, 1); pushd(esi);                             /* push esi */
            ii(0x1016_4292, 1); pushd(edi);                             /* push edi */
            ii(0x1016_4293, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_4294, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4296, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_429c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_429f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_42a2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_42a5, 4); dec(memw_a32[ds, eax + 0x12]);          /* dec word [eax+0x12] */
            ii(0x1016_42a9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_42ac, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1016_42af, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_42b2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_42b4, 2); if(jnzd(0x1016_42d5, 0x1f)) goto l_0x1016_42d5; /* jnz 0x101642d5 */
            ii(0x1016_42b6, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1016_42b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_42bc, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1016_42bf, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_42c4, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1016_42ca, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1016_42d0, 5); calld(0x100d_f2f4, -0x84fe1);           /* call 0x100df2f4 */
        l_0x1016_42d5:
            ii(0x1016_42d5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_42d7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_42d8, 1); popd(edi);                              /* pop edi */
            ii(0x1016_42d9, 1); popd(esi);                              /* pop esi */
            ii(0x1016_42da, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_42db, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_42dc, 1); retd(); return;                         /* ret */
        }
    }
}