using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6281-5852c1cf")]
        public void Method_1010_6281()
        {
            ii(0x1010_6281, 5); push(0x34);                             /* push 0x34 */
            ii(0x1010_6286, 5); call(Definitions.sys_check_available_stack_size, 0x5_fac7); /* call 0x10165d52 */
            ii(0x1010_628b, 1); push(esi);                              /* push esi */
            ii(0x1010_628c, 1); push(edi);                              /* push edi */
            ii(0x1010_628d, 1); push(ebp);                              /* push ebp */
            ii(0x1010_628e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6290, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_6296, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_6299, 3); mov(memb[ss, ebp - 0x4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1010_629c, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1010_629f, 3); mov(memd[ss, ebp - 0xc], ecx);          /* mov [ebp-0xc], ecx */
            ii(0x1010_62a2, 4); movsx(eax, memb[ss, ebp - 0x4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_62a6, 5); call(0x1010_60b4, -0x1f7);              /* call 0x101060b4 */
            ii(0x1010_62ab, 1); push(eax);                              /* push eax */
            ii(0x1010_62ac, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_62af, 1); push(eax);                              /* push eax */
            ii(0x1010_62b0, 5); call(0x1012_36fa, 0x1_d445);            /* call 0x101236fa */
            ii(0x1010_62b5, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_62b8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_62ba, 2); if(jz(0x1010_62f4, 0x38)) goto l_0x1010_62f4; /* jz 0x101062f4 */
            ii(0x1010_62bc, 4); movsx(eax, memb[ss, ebp - 0x4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_62c0, 3); lea(eax, eax + eax * 8);                /* lea eax, [eax+eax*8] */
            ii(0x1010_62c3, 6); push(memd[ds, eax + 0x101b_8b80]);      /* push dword [eax+0x101b8b80] */
            ii(0x1010_62c9, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_62cc, 1); push(eax);                              /* push eax */
            ii(0x1010_62cd, 5); call(0x1012_3850, 0x1_d57e);            /* call 0x10123850 */
            ii(0x1010_62d2, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1010_62d5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_62d7, 2); if(jz(0x1010_62f4, 0x1b)) goto l_0x1010_62f4; /* jz 0x101062f4 */
            ii(0x1010_62d9, 2); push(0x1);                              /* push 0x1 */
            ii(0x1010_62db, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_62de, 1); push(eax);                              /* push eax */
            ii(0x1010_62df, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_62e2, 1); push(eax);                              /* push eax */
            ii(0x1010_62e3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_62e6, 1); push(eax);                              /* push eax */
            ii(0x1010_62e7, 5); call(0x1012_3c73, 0x1_d987);            /* call 0x10123c73 */
            ii(0x1010_62ec, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1010_62ef, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_62f2, 2); jmp(0x1010_62fb, 0x7); goto l_0x1010_62fb; /* jmp 0x101062fb */
        l_0x1010_62f4:
            ii(0x1010_62f4, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
        l_0x1010_62fb:
            ii(0x1010_62fb, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_62fe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6300, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_6301, 1); pop(edi);                               /* pop edi */
            ii(0x1010_6302, 1); pop(esi);                               /* pop esi */
            ii(0x1010_6303, 1); ret();                                  /* ret */
        }
    }
}
