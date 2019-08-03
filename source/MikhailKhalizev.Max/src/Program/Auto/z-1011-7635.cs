using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a370da03-1b23-4860-b992-0c912eb23ee9")]
        public void Method_1011_7635()
        {
            ii(0x1011_7635, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1011_763a, 5); calld(Definitions.sys_check_available_stack_size, 0x4e713); /* call 0x10165d52 */
            ii(0x1011_763f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_7640, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7641, 1); pushd(edi);                             /* push edi */
            ii(0x1011_7642, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_7643, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7645, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1011_764b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_764e, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1011_7651, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1011_7654, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_7657, 5); calld(0x1013_aaa8, 0x2344c);            /* call 0x1013aaa8 */
            ii(0x1011_765c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_765f, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_7662, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_7665, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_7668, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1011_766b, 5); calld(Definitions.my_ctor_0x101b38f8, -0xa0f80); /* call 0x100766f0 */
            ii(0x1011_7670, 3); sub(eax, 0xc);                          /* sub eax, 0xc */
            ii(0x1011_7673, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_7676, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_7679, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_767c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_767f, 3); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1011_7682, 5); calld(Definitions.my_ctor_0x101b4184, -0xa0b97); /* call 0x10076af0 */
            ii(0x1011_7687, 3); sub(eax, 0x10);                         /* sub eax, 0x10 */
            ii(0x1011_768a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_768d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_7690, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_6730); /* mov dword [eax+0x2], 0x101b6730 */
            ii(0x1011_7697, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_769a, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_769d, 4); mov(memw_a32[ds, edx + 0x6], ax);       /* mov [edx+0x6], ax */
            ii(0x1011_76a1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_76a4, 5); calld(/* sys */ 0x1017_cee0, 0x65837);  /* call 0x1017cee0 */
            ii(0x1011_76a9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_76ab, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_76ae, 3); mov(memd_a32[ds, eax + 0x8], edx);      /* mov [eax+0x8], edx */
            ii(0x1011_76b1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_76b4, 4); mov(memb_a32[ds, eax + 0x14], 0);       /* mov byte [eax+0x14], 0x0 */
            ii(0x1011_76b8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_76bb, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_76be, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_76c1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_76c3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_76c4, 1); popd(edi);                              /* pop edi */
            ii(0x1011_76c5, 1); popd(esi);                              /* pop esi */
            ii(0x1011_76c6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_76c7, 1); retd(); return;                         /* ret */
        }
    }
}
