using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_0f78-ced0f478")]
        public void /* sys */ sys_fclose_internal()
        {
            ii(0x1017_0f78, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_0f79, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_0f7a, 1); pushd(edx);                             /* push edx */
            ii(0x1017_0f7b, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_0f7d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_0f7f, 2); if(jzd(0x1017_0fd8, 0x57)) goto l_0x1017_0fd8; /* jz 0x10170fd8 */
            ii(0x1017_0f81, 4); test(memb_a32[ds, eax + 0x4], 0x4);     /* test byte [eax+0x4], 0x4 */
            ii(0x1017_0f85, 2); if(jzd(0x1017_0f91, 0xa)) goto l_0x1017_0f91; /* jz 0x10170f91 */
            ii(0x1017_0f87, 3); mov(eax, memd_a32[ds, ecx + 0xc]);      /* mov eax, [ecx+0xc] */
            ii(0x1017_0f8a, 5); calld(Definitions.sys_fclose, 0x10da);  /* call 0x10172069 */
            ii(0x1017_0f8f, 2); jmpd(0x1017_0fbb, 0x2a); goto l_0x1017_0fbb; /* jmp 0x10170fbb */
        l_0x1017_0f91:
            ii(0x1017_0f91, 3); mov(eax, memd_a32[ds, ecx + 0x4]);      /* mov eax, [ecx+0x4] */
            ii(0x1017_0f94, 5); and(eax, 0xf0);                         /* and eax, 0xf0 */
            ii(0x1017_0f99, 3); cmp(eax, 0x20);                         /* cmp eax, 0x20 */
            ii(0x1017_0f9c, 2); if(jbd(0x1017_0fa7, 0x9)) goto l_0x1017_0fa7; /* jb 0x10170fa7 */
            ii(0x1017_0f9e, 2); if(jbed(0x1017_0fbb, 0x1b)) goto l_0x1017_0fbb; /* jbe 0x10170fbb */
            ii(0x1017_0fa0, 3); cmp(eax, 0x40);                         /* cmp eax, 0x40 */
            ii(0x1017_0fa3, 2); if(jzd(0x1017_0fac, 0x7)) goto l_0x1017_0fac; /* jz 0x10170fac */
            ii(0x1017_0fa5, 2); jmpd(0x1017_0fbb, 0x14); goto l_0x1017_0fbb; /* jmp 0x10170fbb */
        l_0x1017_0fa7:
            ii(0x1017_0fa7, 3); cmp(eax, 0x10);                         /* cmp eax, 0x10 */
            ii(0x1017_0faa, 2); if(jnzd(0x1017_0fbb, 0xf)) goto l_0x1017_0fbb; /* jnz 0x10170fbb */
        l_0x1017_0fac:
            ii(0x1017_0fac, 3); mov(edx, memd_a32[ds, ecx + 0x1c]);     /* mov edx, [ecx+0x1c] */
            ii(0x1017_0faf, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_0fb1, 2); if(jzd(0x1017_0fbb, 0x8)) goto l_0x1017_0fbb; /* jz 0x10170fbb */
            ii(0x1017_0fb3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_0fb5, 6); calld_abs(memd_a32[ds, 0x101b_e1d0]);   /* call dword [0x101be1d0] */ /* Вызов '0x1017_11b4'. */
        l_0x1017_0fbb:
            ii(0x1017_0fbb, 2); mov(eax, memd_a32[ds, ecx]);            /* mov eax, [ecx] */
            ii(0x1017_0fbd, 3); mov(ebx, memd_a32[ds, eax + 0x3c]);     /* mov ebx, [eax+0x3c] */
            ii(0x1017_0fc0, 1); dec(ebx);                               /* dec ebx */
            ii(0x1017_0fc1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_0fc3, 3); mov(memd_a32[ds, eax + 0x3c], ebx);     /* mov [eax+0x3c], ebx */
            ii(0x1017_0fc6, 5); mov(ebx, 0x24);                         /* mov ebx, 0x24 */
            ii(0x1017_0fcb, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_0fcd, 5); calld(Definitions.sys_memset, -0xb1f2); /* call 0x10165de0 */
            ii(0x1017_0fd2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_0fd4, 1); popd(edx);                              /* pop edx */
            ii(0x1017_0fd5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_0fd6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_0fd7, 1); retd(); return;                         /* ret */
        l_0x1017_0fd8:
            ii(0x1017_0fd8, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_0fdd, 1); popd(edx);                              /* pop edx */
            ii(0x1017_0fde, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_0fdf, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_0fe0, 1); retd(); return;                         /* ret */
        }
    }
}
