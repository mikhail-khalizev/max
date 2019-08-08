using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ed3a8383-7402-4188-8b9c-35a3fe714bd6")]
        public void Method_1016_5c97()
        {
            ii(0x1016_5c97, 5); pushd(0xa0);                            /* push 0xa0 */
            ii(0x1016_5c9c, 5); calld(Definitions.sys_check_available_stack_size, 0xb1); /* call 0x10165d52 */
            ii(0x1016_5ca1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_5ca2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_5ca3, 1); pushd(edx);                             /* push edx */
            ii(0x1016_5ca4, 1); pushd(esi);                             /* push esi */
            ii(0x1016_5ca5, 1); pushd(edi);                             /* push edi */
            ii(0x1016_5ca6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_5ca7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_5ca9, 6); sub(esp, 0x84);                         /* sub esp, 0x84 */
            ii(0x1016_5caf, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_5cb2, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1016_5cb6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_5cb9, 6); lea(eax, ebp - 0x84);                   /* lea eax, [ebp-0x84] */
            ii(0x1016_5cbf, 5); calld(0x1016_4c63, -0x1061);            /* call 0x10164c63 */
            ii(0x1016_5cc4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1016_5cc7, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1016_5ccb, 6); lea(eax, ebp - 0x84);                   /* lea eax, [ebp-0x84] */
            ii(0x1016_5cd1, 5); calld(0x1016_5bda, -0xfc);              /* call 0x10165bda */
            ii(0x1016_5cd6, 3); mov(eax, memd_a32[ss, ebp - 0x6d]);     /* mov eax, [ebp-0x6d] */
            ii(0x1016_5cd9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_5cdc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_5cde, 6); lea(eax, ebp - 0x84);                   /* lea eax, [ebp-0x84] */
            ii(0x1016_5ce4, 5); calld(0x1016_564c, -0x69d);             /* call 0x1016564c */
            ii(0x1016_5ce9, 2); jmpd(0x1016_5cf8, 0xd); goto l_0x1016_5cf8; /* jmp 0x10165cf8 */
        //    ii(0x1016_5ceb, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1016_5ced, 6); lea(eax, ebp - 0x84);                   /* lea eax, [ebp-0x84] */
        //    ii(0x1016_5cf3, 5); calld(0x1016_564c, -0x6ac);             /* call 0x1016564c */
        l_0x1016_5cf8:
            ii(0x1016_5cf8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_5cfb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_5cfd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_5cfe, 1); popd(edi);                              /* pop edi */
            ii(0x1016_5cff, 1); popd(esi);                              /* pop esi */
            ii(0x1016_5d00, 1); popd(edx);                              /* pop edx */
            ii(0x1016_5d01, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_5d02, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_5d03, 1); retd(); return;                         /* ret */
        }
    }
}
