using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_5807-26989434")]
        public void Method_1012_5807()
        {
            ii(0x1012_5807, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x1012_580c, 5); calld(Definitions.sys_check_available_stack_size, 0x4_0541); /* call 0x10165d52 */
            ii(0x1012_5811, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_5812, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_5813, 1); pushd(edx);                             /* push edx */
            ii(0x1012_5814, 1); pushd(esi);                             /* push esi */
            ii(0x1012_5815, 1); pushd(edi);                             /* push edi */
            ii(0x1012_5816, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_5817, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_5819, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x1012_581f, 5); mov(al, memb_a32[ds, 0x101c_59b9]);     /* mov al, [0x101c59b9] */
            ii(0x1012_5824, 5); mov(memb_a32[ds, 0x101b_b457], al);     /* mov [0x101bb457], al */
            ii(0x1012_5829, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1012_582e, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1012_5833, 5); mov(eax, 0x101b_b456);                  /* mov eax, 0x101bb456 */
            ii(0x1012_5838, 5); calld(0x1012_4890, -0xfad);             /* call 0x10124890 */
            ii(0x1012_583d, 7); mov(memb_a32[ds, 0x101c_61a8], 0x4);    /* mov byte [0x101c61a8], 0x4 */
            ii(0x1012_5844, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_5846, 5); mov(al, memb_a32[ds, 0x101c_5631]);     /* mov al, [0x101c5631] */
            ii(0x1012_584b, 3); cmp(eax, 0x6);                          /* cmp eax, 0x6 */
            ii(0x1012_584e, 2); if(jzd(0x1012_5859, 0x9)) goto l_0x1012_5859; /* jz 0x10125859 */
            ii(0x1012_5850, 7); mov(memb_a32[ds, 0x101c_5631], 0x6);    /* mov byte [0x101c5631], 0x6 */
            ii(0x1012_5857, 2); jmpd(0x1012_5860, 0x7); goto l_0x1012_5860; /* jmp 0x10125860 */
        l_0x1012_5859:
            ii(0x1012_5859, 7); mov(memb_a32[ds, 0x101c_5631], 0x7);    /* mov byte [0x101c5631], 0x7 */
        l_0x1012_5860:
            ii(0x1012_5860, 5); calld(0x1014_82f4, 0x2_2a8f);           /* call 0x101482f4 */
            ii(0x1012_5865, 5); mov(memd_a32[ds, 0x101c_61a0], eax);    /* mov [0x101c61a0], eax */
            ii(0x1012_586a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_586b, 1); popd(edi);                              /* pop edi */
            ii(0x1012_586c, 1); popd(esi);                              /* pop esi */
            ii(0x1012_586d, 1); popd(edx);                              /* pop edx */
            ii(0x1012_586e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_586f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_5870, 1); retd();                                 /* ret */
        }
    }
}
