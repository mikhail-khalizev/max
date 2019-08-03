using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("41319fff-a727-482b-ae8b-c7f82694c8cb")]
        public void /* sys */ Method_1018_6d4b()
        {
            ii(0x1018_6d4b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_6d4c, 1); pushd(edx);                             /* push edx */
            ii(0x1018_6d4d, 6); mov(edx, memd_a32[ds, 0x101b_de0c]);    /* mov edx, [0x101bde0c] */
            ii(0x1018_6d53, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_6d55, 2); if(jzd(0x1018_6d96, 0x3f)) goto l_0x1018_6d96; /* jz 0x10186d96 */
            ii(0x1018_6d57, 3); mov(edx, memd_a32[ds, edx + 0x24]);     /* mov edx, [edx+0x24] */
            ii(0x1018_6d5a, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1018_6d5c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_6d5e, 3); lea(ebx, eax + 0x4);                    /* lea ebx, [eax+0x4] */
            ii(0x1018_6d61, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_6d63, 5); mov(al, memb_a32[ds, 0x101b_e58e]);     /* mov al, [0x101be58e] */
            ii(0x1018_6d68, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1018_6d6b, 2); if(jld(0x1018_6d89, 0x1c)) goto l_0x1018_6d89; /* jl 0x10186d89 */
            ii(0x1018_6d6d, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1018_6d70, 2); if(jgd(0x1018_6d89, 0x17)) goto l_0x1018_6d89; /* jg 0x10186d89 */
            ii(0x1018_6d72, 7); cmp(memb_a32[ds, 0x101b_e590], 0);      /* cmp byte [0x101be590], 0x0 */
            ii(0x1018_6d79, 2); if(jnzd(0x1018_6d89, 0xe)) goto l_0x1018_6d89; /* jnz 0x10186d89 */
            ii(0x1018_6d7b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_6d7d, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1018_6d80, 3); lsl(eax, ax);                           /* lsl eax, ax */
            ii(0x1018_6d83, 1); inc(eax);                               /* inc eax */
            ii(0x1018_6d84, 5); mov(memd_a32[ds, 0x101b_e560], eax);    /* mov [0x101be560], eax */
        l_0x1018_6d89:
            ii(0x1018_6d89, 6); cmp(ebx, memd_a32[ds, 0x101b_e560]);    /* cmp ebx, [0x101be560] */
            ii(0x1018_6d8f, 2); if(jnzd(0x1018_6d96, 0x5)) goto l_0x1018_6d96; /* jnz 0x10186d96 */
            ii(0x1018_6d91, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1018_6d93, 1); popd(edx);                              /* pop edx */
            ii(0x1018_6d94, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_6d95, 1); retd(); return;                         /* ret */
        l_0x1018_6d96:
            ii(0x1018_6d96, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_6d98, 1); popd(edx);                              /* pop edx */
            ii(0x1018_6d99, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_6d9a, 1); retd(); return;                         /* ret */
        }
    }
}