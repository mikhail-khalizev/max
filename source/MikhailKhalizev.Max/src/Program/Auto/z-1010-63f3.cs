using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_63f3-46ddafe8")]
        public void Method_1010_63f3()
        {
            ii(0x1010_63f3, 5); push(0x50);                             /* push 0x50 */
            ii(0x1010_63f8, 5); call(Definitions.sys_check_available_stack_size, 0x5_f955); /* call 0x10165d52 */
            ii(0x1010_63fd, 1); push(esi);                              /* push esi */
            ii(0x1010_63fe, 1); push(edi);                              /* push edi */
            ii(0x1010_63ff, 1); push(ebp);                              /* push ebp */
            ii(0x1010_6400, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6402, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x1010_6408, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1010_640b, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1010_640e, 3); mov(memb[ss, ebp - 8], bl);             /* mov [ebp-0x8], bl */
            ii(0x1010_6411, 3); mov(memb[ss, ebp - 4], cl);             /* mov [ebp-0x4], cl */
            ii(0x1010_6414, 5); mov(eax, 0x4b);                         /* mov eax, 0x4b */
            ii(0x1010_6419, 5); call(0x1007_5fdc, -0x9_0442);           /* call 0x10075fdc */
            ii(0x1010_641e, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1010_6421, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1010_6426, 5); call(0x1007_5fdc, -0x9_044f);           /* call 0x10075fdc */
            ii(0x1010_642b, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1010_642e, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1010_6431, 3); mov(memb[ss, ebp - 20], al);            /* mov [ebp-0x14], al */
        l_0x1010_6434:
            ii(0x1010_6434, 3); inc(memb[ss, ebp - 20]);                /* inc byte [ebp-0x14] */
            ii(0x1010_6437, 4); movsx(eax, memb[ss, ebp - 20]);         /* movsx eax, byte [ebp-0x14] */
            ii(0x1010_643b, 3); lea(eax, memd[ds, eax + eax * 8]);      /* lea eax, [eax+eax*8] */
            ii(0x1010_643e, 7); test(memb[ds, eax + 0x101b_8b88], 1);   /* test byte [eax+0x101b8b88], 0x1 */
            ii(0x1010_6445, 2); if(jnz(0x1010_644d, 6)) goto l_0x1010_644d; /* jnz 0x1010644d */
            ii(0x1010_6447, 4); cmp(memb[ss, ebp - 20], 0x76);          /* cmp byte [ebp-0x14], 0x76 */
            ii(0x1010_644b, 2); if(jl(0x1010_644f, 2)) goto l_0x1010_644f; /* jl 0x1010644f */
        l_0x1010_644d:
            ii(0x1010_644d, 2); jmp(0x1010_64a8, 0x59); goto l_0x1010_64a8; /* jmp 0x101064a8 */
        l_0x1010_644f:
            ii(0x1010_644f, 4); movsx(eax, memb[ss, ebp - 20]);         /* movsx eax, byte [ebp-0x14] */
            ii(0x1010_6453, 3); lea(eax, memd[ds, eax + eax * 8]);      /* lea eax, [eax+eax*8] */
            ii(0x1010_6456, 7); test(memb[ds, eax + 0x101b_8b88], 2);   /* test byte [eax+0x101b8b88], 0x2 */
            ii(0x1010_645d, 2); if(jz(0x1010_6481, 0x22)) goto l_0x1010_6481; /* jz 0x10106481 */
            ii(0x1010_645f, 3); lea(edx, memd[ss, ebp - 32]);           /* lea edx, [ebp-0x20] */
            ii(0x1010_6462, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_6465, 5); call(0x1010_6a64, 0x5fa);               /* call 0x10106a64 */
            ii(0x1010_646a, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_646e, 2); if(jz(0x1010_647f, 0xf)) goto l_0x1010_647f; /* jz 0x1010647f */
            ii(0x1010_6470, 3); mov(ebx, memd[ss, ebp - 32]);           /* mov ebx, [ebp-0x20] */
            ii(0x1010_6473, 4); movsx(edx, memb[ss, ebp - 20]);         /* movsx edx, byte [ebp-0x14] */
            ii(0x1010_6477, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_647a, 5); call(0x1010_610a, -0x375);              /* call 0x1010610a */
        l_0x1010_647f:
            ii(0x1010_647f, 2); jmp(0x1010_64a6, 0x25); goto l_0x1010_64a6; /* jmp 0x101064a6 */
        l_0x1010_6481:
            ii(0x1010_6481, 5); mov(ebx, 0x1e);                         /* mov ebx, 0x1e */
            ii(0x1010_6486, 3); lea(edx, memd[ss, ebp - 64]);           /* lea edx, [ebp-0x40] */
            ii(0x1010_6489, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_648c, 5); call(0x1013_ba86, 0x3_55f5);            /* call 0x1013ba86 */
            ii(0x1010_6491, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_6495, 2); if(jz(0x1010_64a6, 0xf)) goto l_0x1010_64a6; /* jz 0x101064a6 */
            ii(0x1010_6497, 3); lea(ebx, memd[ss, ebp - 64]);           /* lea ebx, [ebp-0x40] */
            ii(0x1010_649a, 4); movsx(edx, memb[ss, ebp - 20]);         /* movsx edx, byte [ebp-0x14] */
            ii(0x1010_649e, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_64a1, 5); call(0x1010_6205, -0x2a1);              /* call 0x10106205 */
        l_0x1010_64a6:
            ii(0x1010_64a6, 2); jmp(0x1010_6434, -0x74); goto l_0x1010_6434; /* jmp 0x10106434 */
        l_0x1010_64a8:
            ii(0x1010_64a8, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_64ac, 2); if(jz(0x1010_64b4, 6)) goto l_0x1010_64b4; /* jz 0x101064b4 */
            ii(0x1010_64ae, 4); cmp(memb[ss, ebp - 8], 0x44);           /* cmp byte [ebp-0x8], 0x44 */
            ii(0x1010_64b2, 2); if(jz(0x1010_64b6, 2)) goto l_0x1010_64b6; /* jz 0x101064b6 */
        l_0x1010_64b4:
            ii(0x1010_64b4, 2); jmp(0x1010_64f2, 0x3c); goto l_0x1010_64f2; /* jmp 0x101064f2 */
        l_0x1010_64b6:
            ii(0x1010_64b6, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1010_64bb, 5); call(0x1007_5fdc, -0x9_04e4);           /* call 0x10075fdc */
            ii(0x1010_64c0, 6); mov(memw[ds, 0x101c_3966], ax);         /* mov [0x101c3966], ax */
            ii(0x1010_64c6, 5); mov(eax, 0x4b);                         /* mov eax, 0x4b */
            ii(0x1010_64cb, 5); call(0x1007_5fdc, -0x9_04f4);           /* call 0x10075fdc */
            ii(0x1010_64d0, 6); mov(memw[ds, 0x101c_3968], ax);         /* mov [0x101c3968], ax */
            ii(0x1010_64d6, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1010_64da, 5); mov(eax, 0x4b);                         /* mov eax, 0x4b */
            ii(0x1010_64df, 5); call(0x100c_aafc, -0x3_b9e8);           /* call 0x100caafc */
            ii(0x1010_64e4, 4); movsx(edx, memw[ss, ebp - 28]);         /* movsx edx, word [ebp-0x1c] */
            ii(0x1010_64e8, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1010_64ed, 5); call(0x100c_aafc, -0x3_b9f6);           /* call 0x100caafc */
        l_0x1010_64f2:
            ii(0x1010_64f2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_64f4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_64f5, 1); pop(edi);                               /* pop edi */
            ii(0x1010_64f6, 1); pop(esi);                               /* pop esi */
            ii(0x1010_64f7, 1); ret();                                  /* ret */
        }
    }
}
