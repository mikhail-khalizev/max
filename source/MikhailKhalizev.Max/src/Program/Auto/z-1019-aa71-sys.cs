using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("55264207-c013-4125-b283-ba30082f1657")]
        public void /* sys */ Method_1019_aa71()
        {
            ii(0x1019_aa71, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_aa72, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_aa73, 1); pushd(edx);                             /* push edx */
            ii(0x1019_aa74, 6); mov(ah, memb_a32[ds, 0x101b_e5e1]);     /* mov ah, [0x101be5e1] */
            ii(0x1019_aa7a, 3); and(ah, 0xf8);                          /* and ah, 0xf8 */
            ii(0x1019_aa7d, 2); mov(dl, ah);                            /* mov dl, ah */
            ii(0x1019_aa7f, 6); mov(memb_a32[ds, 0x101b_e5e1], ah);     /* mov [0x101be5e1], ah */
            ii(0x1019_aa85, 3); or(dl, 0x4);                            /* or dl, 0x4 */
            ii(0x1019_aa88, 5); mov(ecx, 0x101b_e5a0);                  /* mov ecx, 0x101be5a0 */
            ii(0x1019_aa8d, 6); mov(memb_a32[ds, 0x101b_e5e1], dl);     /* mov [0x101be5e1], dl */
            ii(0x1019_aa93, 2); jmpd(0x1019_aad7, 0x42); goto l_0x1019_aad7; /* jmp 0x1019aad7 */
        l_0x1019_aa95:
            ii(0x1019_aa95, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
            ii(0x1019_aa9a, 5); calld(Definitions.sys_malloc, -0x2fac1); /* call 0x1016afde */
            ii(0x1019_aa9f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_aaa1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_aaa3, 2); if(jnzd(0x1019_aac4, 0x1f)) goto l_0x1019_aac4; /* jnz 0x1019aac4 */
            ii(0x1019_aaa5, 5); mov(eax, 0x8);                          /* mov eax, 0x8 */
            ii(0x1019_aaaa, 5); calld(Definitions.sys_malloc, -0x2fad1); /* call 0x1016afde */
            ii(0x1019_aaaf, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_aab1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_aab3, 2); if(jnzd(0x1019_aac4, 0xf)) goto l_0x1019_aac4; /* jnz 0x1019aac4 */
            ii(0x1019_aab5, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1019_aaba, 5); mov(eax, StringDefinitions.NotEnoughMemoryToAllocateFileStructures); /* mov eax, 0x101b3714 */
            ii(0x1019_aabf, 5); calld(/* sys */ 0x1018_1002, -0x19ac2); /* call 0x10181002 */
        l_0x1019_aac4:
            ii(0x1019_aac4, 5); mov(eax, memd_a32[ds, 0x1020_b70c]);    /* mov eax, [0x1020b70c] */
            ii(0x1019_aac9, 3); mov(memd_a32[ds, ebx + 0x4], ecx);      /* mov [ebx+0x4], ecx */
            ii(0x1019_aacc, 6); mov(memd_a32[ds, 0x1020_b70c], ebx);    /* mov [0x1020b70c], ebx */
            ii(0x1019_aad2, 3); add(ecx, 0x1a);                         /* add ecx, 0x1a */
            ii(0x1019_aad5, 2); mov(memd_a32[ds, ebx], eax);            /* mov [ebx], eax */
        l_0x1019_aad7:
            ii(0x1019_aad7, 3); mov(edx, memd_a32[ds, ecx + 0xc]);      /* mov edx, [ecx+0xc] */
            ii(0x1019_aada, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1019_aadc, 2); if(jnzd(0x1019_aa95, -0x49)) goto l_0x1019_aa95; /* jnz 0x1019aa95 */
            ii(0x1019_aade, 6); mov(memd_a32[ds, 0x1020_a1f4], edx);    /* mov [0x1020a1f4], edx */
            ii(0x1019_aae4, 1); popd(edx);                              /* pop edx */
            ii(0x1019_aae5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_aae6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_aae7, 1); retd(); return;                         /* ret */
        }
    }
}
