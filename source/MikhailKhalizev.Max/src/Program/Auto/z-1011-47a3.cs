using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_47a3-c61f0295")]
        public void Method_1011_47a3()
        {
            ii(0x1011_47a3, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_47a8, 5); call(Definitions.sys_check_available_stack_size, 0x5_15a5); /* call 0x10165d52 */
            ii(0x1011_47ad, 1); push(ebx);                              /* push ebx */
            ii(0x1011_47ae, 1); push(ecx);                              /* push ecx */
            ii(0x1011_47af, 1); push(edx);                              /* push edx */
            ii(0x1011_47b0, 1); push(esi);                              /* push esi */
            ii(0x1011_47b1, 1); push(edi);                              /* push edi */
            ii(0x1011_47b2, 1); push(ebp);                              /* push ebp */
            ii(0x1011_47b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_47b5, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1011_47bb, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1011_47be, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_47c1, 5); call(0x1011_3b89, -0xc3d);              /* call 0x10113b89 */
            ii(0x1011_47c6, 5); call(0x1010_d90b, -0x6ec0);             /* call 0x1010d90b */
            ii(0x1011_47cb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_47cd, 6); if(jz(0x1011_4858, 0x85)) goto l_0x1011_4858; /* jz 0x10114858 */
            ii(0x1011_47d3, 5); mov(eax, 0x45);                         /* mov eax, 0x45 */
            ii(0x1011_47d8, 5); call(0x1007_5fdc, -0x9_e801);           /* call 0x10075fdc */
            ii(0x1011_47dd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_47df, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_47e2, 6); mov(memb[ds, eax + 0x50e], dl);         /* mov [eax+0x50e], dl */
            ii(0x1011_47e8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_47eb, 6); mov(al, memb[ds, eax + 0x50e]);         /* mov al, [eax+0x50e] */
            ii(0x1011_47f1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_47f6, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1011_47f9, 6); mov(edx, memd[ds, eax + 0x101b_9794]);  /* mov edx, [eax+0x101b9794] */
            ii(0x1011_47ff, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_4802, 5); add(eax, 0x4f0);                        /* add eax, 0x4f0 */
            ii(0x1011_4807, 5); call(Definitions.sys_strcpy, 0x5_16c3); /* call 0x10165ecf */
            ii(0x1011_480c, 5); mov(eax, 0x4b);                         /* mov eax, 0x4b */
            ii(0x1011_4811, 5); call(0x1007_5fdc, -0x9_e83a);           /* call 0x10075fdc */
            ii(0x1011_4816, 6); mov(memw[ds, 0x101c_3968], ax);         /* mov [0x101c3968], ax */
            ii(0x1011_481c, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1011_4821, 5); call(0x1007_5fdc, -0x9_e84a);           /* call 0x10075fdc */
            ii(0x1011_4826, 6); mov(memw[ds, 0x101c_3966], ax);         /* mov [0x101c3966], ax */
            ii(0x1011_482c, 5); mov(edx, 6);                            /* mov edx, 0x6 */
            ii(0x1011_4831, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_4834, 5); call(0x1011_2a06, -0x1e33);             /* call 0x10112a06 */
            ii(0x1011_4839, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_483b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_483e, 5); call(0x1011_46da, -0x169);              /* call 0x101146da */
            ii(0x1011_4843, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1011_4848, 5); call(0x1007_5fdc, -0x9_e871);           /* call 0x10075fdc */
            ii(0x1011_484d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_4850, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_4853, 5); call(0x1011_4119, -0x73f);              /* call 0x10114119 */
        l_0x1011_4858:
            ii(0x1011_4858, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_485a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_485d, 5); call(0x1011_3aca, -0xd98);              /* call 0x10113aca */
            ii(0x1011_4862, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_4864, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_4865, 1); pop(edi);                               /* pop edi */
            ii(0x1011_4866, 1); pop(esi);                               /* pop esi */
            ii(0x1011_4867, 1); pop(edx);                               /* pop edx */
            ii(0x1011_4868, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_4869, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_486a, 1); ret();                                  /* ret */
        }
    }
}
