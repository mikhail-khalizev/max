using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a60616f3-8427-4fe5-bb30-d4bc5115d10a")]
        public void Method_1019_c685()
        {
            ii(0x1019_c685, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_c686, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_c688, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_c689, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_c68a, 1); pushd(edx);                             /* push edx */
            ii(0x1019_c68b, 1); pushd(esi);                             /* push esi */
            ii(0x1019_c68c, 3); mov(ecx, memd_a32[ss, ebp + 0x10]);     /* mov ecx, [ebp+0x10] */
            ii(0x1019_c68f, 3); mov(ebx, memd_a32[ss, ebp + 0x14]);     /* mov ebx, [ebp+0x14] */
            ii(0x1019_c692, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1019_c694, 2); if(jzd(0x1019_c6ab, 0x15)) goto l_0x1019_c6ab; /* jz 0x1019c6ab */
            ii(0x1019_c696, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1019_c698, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1019_c69a, 1); pushd(edx);                             /* push edx */
            ii(0x1019_c69b, 3); mov(edx, memd_a32[ss, ebp + 0xc]);      /* mov edx, [ebp+0xc] */
            ii(0x1019_c69e, 1); pushd(edx);                             /* push edx */
            ii(0x1019_c69f, 3); mov(esi, memd_a32[ss, ebp + 0x8]);      /* mov esi, [ebp+0x8] */
            ii(0x1019_c6a2, 1); pushd(esi);                             /* push esi */
            ii(0x1019_c6a3, 5); calld(0x1019_c6c6, 0x1e);               /* call 0x1019c6c6 */
            ii(0x1019_c6a8, 3); fstp(memq_a32[ss, ebp + 0x8]);          /* fstp qword [ebp+0x8] */
        l_0x1019_c6ab:
            ii(0x1019_c6ab, 3); lea(eax, ebp + 0x8);                    /* lea eax, [ebp+0x8] */
            ii(0x1019_c6ae, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1019_c6b0, 5); calld(0x1019_cd36, 0x681);              /* call 0x1019cd36 */
            ii(0x1019_c6b5, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1019_c6b7, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_c6b9, 5); calld(0x1019_ccfc, 0x63e);              /* call 0x1019ccfc */
            ii(0x1019_c6be, 1); popd(esi);                              /* pop esi */
            ii(0x1019_c6bf, 1); popd(edx);                              /* pop edx */
            ii(0x1019_c6c0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_c6c1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_c6c2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_c6c3, 3); retd(0x10); return;                     /* ret 0x10 */
        }
    }
}
