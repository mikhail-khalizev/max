using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ec9ad791-c0de-42fb-95ff-89754d5866b8")]
        public void Method_1010_60b4()
        {
            ii(0x1010_60b4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_60b9, 5); calld(Definitions.sys_check_available_stack_size, 0x5_fc94); /* call 0x10165d52 */
            ii(0x1010_60be, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_60bf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_60c0, 1); pushd(edx);                             /* push edx */
            ii(0x1010_60c1, 1); pushd(esi);                             /* push esi */
            ii(0x1010_60c2, 1); pushd(edi);                             /* push edi */
            ii(0x1010_60c3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_60c4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_60c6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_60cc, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x1010_60cf, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_60d3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1010_60d6:
            ii(0x1010_60d6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_60d9, 3); lea(eax, eax + eax * 8);                /* lea eax, [eax+eax*8] */
            ii(0x1010_60dc, 7); test(memb_a32[ds, eax + 0x101b_8b88], 0x1); /* test byte [eax+0x101b8b88], 0x1 */
            ii(0x1010_60e3, 2); if(jnzd(0x1010_60ef, 0xa)) goto l_0x1010_60ef; /* jnz 0x101060ef */
            ii(0x1010_60e5, 4); add(memd_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* add dword [ebp-0x8], 0xffffffff */
            ii(0x1010_60e9, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1010_60ed, 2); if(jnzd(0x1010_60d6, -0x19)) goto l_0x1010_60d6; /* jnz 0x101060d6 */
        l_0x1010_60ef:
            ii(0x1010_60ef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_60f2, 3); lea(eax, eax + eax * 8);                /* lea eax, [eax+eax*8] */
            ii(0x1010_60f5, 6); mov(eax, memd_a32[ds, eax + 0x101b_8b80]); /* mov eax, [eax+0x101b8b80] */
            ii(0x1010_60fb, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_60fe, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_6101, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6103, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_6104, 1); popd(edi);                              /* pop edi */
            ii(0x1010_6105, 1); popd(esi);                              /* pop esi */
            ii(0x1010_6106, 1); popd(edx);                              /* pop edx */
            ii(0x1010_6107, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_6108, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_6109, 1); retd(); return;                         /* ret */
        }
    }
}
