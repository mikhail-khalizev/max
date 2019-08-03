using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a1e0743e-e899-422c-9e14-63ea9c786654")]
        public void Method_1015_24a1()
        {
            ii(0x1015_24a1, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_24a6, 5); calld(Definitions.sys_check_available_stack_size, 0x138a7); /* call 0x10165d52 */
            ii(0x1015_24ab, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_24ac, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_24ad, 1); pushd(edx);                             /* push edx */
            ii(0x1015_24ae, 1); pushd(esi);                             /* push esi */
            ii(0x1015_24af, 1); pushd(edi);                             /* push edi */
            ii(0x1015_24b0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_24b1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_24b3, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_24b9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_24bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_24bf, 7); cmp(memb_a32[ds, eax + 0x9e], 0);       /* cmp byte [eax+0x9e], 0x0 */
            ii(0x1015_24c6, 2); if(jzd(0x1015_2529, 0x61)) goto l_0x1015_2529; /* jz 0x10152529 */
            ii(0x1015_24c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_24cb, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1015_24cf, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_24d2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_24d5, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1015_24d9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_24dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_24df, 7); mov(dx, memw_a32[ds, eax + 0x9f]);      /* mov dx, [eax+0x9f] */
            ii(0x1015_24e6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_24e9, 4); mov(memw_a32[ds, eax + 0x1a], dx);      /* mov [eax+0x1a], dx */
            ii(0x1015_24ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_24f0, 7); mov(dx, memw_a32[ds, eax + 0xa1]);      /* mov dx, [eax+0xa1] */
            ii(0x1015_24f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_24fa, 4); mov(memw_a32[ds, eax + 0x1c], dx);      /* mov [eax+0x1c], dx */
            ii(0x1015_24fe, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_2501, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_2506, 5); calld(0x1010_3752, -0x4edb9);           /* call 0x10103752 */
            ii(0x1015_250b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_250e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_2511, 4); mov(memw_a32[ds, edx + 0x1a], ax);      /* mov [edx+0x1a], ax */
            ii(0x1015_2515, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_2518, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_251b, 4); mov(memw_a32[ds, edx + 0x1c], ax);      /* mov [edx+0x1c], ax */
            ii(0x1015_251f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_2522, 7); mov(memb_a32[ds, eax + 0x9e], 0);       /* mov byte [eax+0x9e], 0x0 */
        l_0x1015_2529:
            ii(0x1015_2529, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_252b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_252c, 1); popd(edi);                              /* pop edi */
            ii(0x1015_252d, 1); popd(esi);                              /* pop esi */
            ii(0x1015_252e, 1); popd(edx);                              /* pop edx */
            ii(0x1015_252f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_2530, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_2531, 1); retd(); return;                         /* ret */
        }
    }
}