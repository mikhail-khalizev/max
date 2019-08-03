using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("144ab983-4504-4eed-b6a1-a320f7c55872")]
        public void /* sys */ Method_1017_e0ab()
        {
            ii(0x1017_e0ab, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_e0ac, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_e0ad, 1); pushd(edx);                             /* push edx */
            ii(0x1017_e0ae, 1); pushd(esi);                             /* push esi */
            ii(0x1017_e0af, 1); pushd(edi);                             /* push edi */
            ii(0x1017_e0b0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_e0b1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_e0b3, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1017_e0b9, 10); mov(memd_a32[ds, 0x101b_e4e8], 0);     /* mov dword [0x101be4e8], 0x0 */
            ii(0x1017_e0c3, 5); mov(eax, memd_a32[ds, 0x1020_a13c]);    /* mov eax, [0x1020a13c] */
            ii(0x1017_e0c8, 5); calld(/* sys */ 0x1017_d1da, -0xef3);   /* call 0x1017d1da */
            ii(0x1017_e0cd, 6); pushd(memd_a32[ds, 0x1020_a1ac]);       /* push dword [0x1020a1ac] */
            ii(0x1017_e0d3, 7); movzx(eax, memw_a32[ds, 0x1020_a1ba]);  /* movzx eax, word [0x1020a1ba] */
            ii(0x1017_e0da, 1); pushd(eax);                             /* push eax */
            ii(0x1017_e0db, 6); pushd(memd_a32[ds, 0x1020_a1b6]);       /* push dword [0x1020a1b6] */
            ii(0x1017_e0e1, 5); calld(/* sys */ 0x1019_4d46, 0x16c60);  /* call 0x10194d46 */
            ii(0x1017_e0e6, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1017_e0e9, 6); pushd(memd_a32[ds, 0x1020_a1ac]);       /* push dword [0x1020a1ac] */
            ii(0x1017_e0ef, 7); movzx(eax, memw_a32[ds, 0x1020_a1c0]);  /* movzx eax, word [0x1020a1c0] */
            ii(0x1017_e0f6, 1); pushd(eax);                             /* push eax */
            ii(0x1017_e0f7, 6); pushd(memd_a32[ds, 0x1020_a1bc]);       /* push dword [0x1020a1bc] */
            ii(0x1017_e0fd, 5); calld(/* sys */ 0x1019_4d46, 0x16c44);  /* call 0x10194d46 */
            ii(0x1017_e102, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1017_e105, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1017_e10c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_e10f, 1); leaved();                               /* leave */
            ii(0x1017_e110, 1); popd(edi);                              /* pop edi */
            ii(0x1017_e111, 1); popd(esi);                              /* pop esi */
            ii(0x1017_e112, 1); popd(edx);                              /* pop edx */
            ii(0x1017_e113, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_e114, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_e115, 1); retd(); return;                         /* ret */
        }
    }
}
