using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_f5bc-9029f946")]
        public void /* sys */ Method_1016_f5bc()
        {
            ii(0x1016_f5bc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_f5bd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_f5be, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_f5c1, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_f5c3, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1016_f5c5, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_f5c7, 5); calld(/* sys */ 0x1016_f55c, -0x70);    /* call 0x1016f55c */
            ii(0x1016_f5cc, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_f5cf, 2); if(jzd(0x1016_f5fe, 0x2d)) goto l_0x1016_f5fe; /* jz 0x1016f5fe */
            ii(0x1016_f5d1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_f5d3, 4); mov(ax, memw_a32[ss, esp]);             /* mov ax, [esp] */
            ii(0x1016_f5d7, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_f5d9, 2); mov(memd_a32[ds, ebx], eax);            /* mov [ebx], eax */
            ii(0x1016_f5db, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_f5dd, 5); calld(/* sys */ 0x1016_f55c, -0x86);    /* call 0x1016f55c */
            ii(0x1016_f5e2, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_f5e5, 2); if(jzd(0x1016_f5fe, 0x17)) goto l_0x1016_f5fe; /* jz 0x1016f5fe */
            ii(0x1016_f5e7, 2); mov(edx, memd_a32[ds, ebx]);            /* mov edx, [ebx] */
            ii(0x1016_f5e9, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1016_f5ec, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_f5ee, 2); mov(memd_a32[ds, ebx], edx);            /* mov [ebx], edx */
            ii(0x1016_f5f0, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1016_f5f2, 4); mov(ax, memw_a32[ss, esp]);             /* mov ax, [esp] */
            ii(0x1016_f5f6, 2); or(ecx, eax);                           /* or ecx, eax */
            ii(0x1016_f5f8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_f5fa, 2); mov(memd_a32[ds, ebx], ecx);            /* mov [ebx], ecx */
            ii(0x1016_f5fc, 2); jmpd(0x1016_f603, 0x5); goto l_0x1016_f603; /* jmp 0x1016f603 */
        l_0x1016_f5fe:
            ii(0x1016_f5fe, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
        l_0x1016_f603:
            ii(0x1016_f603, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_f606, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_f607, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_f608, 1); retd(); return;                         /* ret */
        }
    }
}
