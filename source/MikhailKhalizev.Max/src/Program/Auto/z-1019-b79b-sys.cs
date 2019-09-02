using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_b79b-a0b7e2df")]
        public void /* sys */ Method_1019_b79b()
        {
            ii(0x1019_b79b, 1); push(ebx);                              /* push ebx */
            ii(0x1019_b79c, 1); push(ecx);                              /* push ecx */
            ii(0x1019_b79d, 1); push(esi);                              /* push esi */
            ii(0x1019_b79e, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1019_b7a0, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1019_b7a2, 5); mov(eax, 2);                            /* mov eax, 0x2 */
            ii(0x1019_b7a7, 5); call(0x1019_c529, 0xd7d);               /* call 0x1019c529 */
            ii(0x1019_b7ac, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_b7ae, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1019_b7b0, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1019_b7b2, 7); mov(eax, memd[ds, eax * 4 + 0x101b_7708]); /* mov eax, [eax*4+0x101b7708] */
            ii(0x1019_b7b9, 5); call(/* sys */ 0x1018_0f4d, -0x1_a871); /* call 0x10180f4d */
            ii(0x1019_b7be, 5); mov(eax, StringDefinitions.In);         /* mov eax, 0x101b37f9 */
            ii(0x1019_b7c3, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1019_b7c5, 5); call(/* sys */ 0x1018_0f4d, -0x1_a87d); /* call 0x10180f4d */
            ii(0x1019_b7ca, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1019_b7cc, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_b7ce, 5); call(/* sys */ 0x1018_0f4d, -0x1_a886); /* call 0x10180f4d */
            ii(0x1019_b7d3, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1019_b7d8, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1019_b7da, 5); call(/* sys */ 0x1017_29f1, -0x2_8dee); /* call 0x101729f1 */
            ii(0x1019_b7df, 1); pop(esi);                               /* pop esi */
            ii(0x1019_b7e0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_b7e1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_b7e2, 1); ret();                                  /* ret */
        }
    }
}
