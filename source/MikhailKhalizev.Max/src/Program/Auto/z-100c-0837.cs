using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_0837-6d1d2013")]
        public void Method_100c_0837()
        {
            ii(0x100c_0837, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100c_083c, 5); call(Definitions.sys_check_available_stack_size, 0xa_5511); /* call 0x10165d52 */
            ii(0x100c_0841, 1); push(esi);                              /* push esi */
            ii(0x100c_0842, 1); push(edi);                              /* push edi */
            ii(0x100c_0843, 1); push(ebp);                              /* push ebp */
            ii(0x100c_0844, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_0846, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100c_084c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_084f, 3); mov(memb[ss, ebp - 0x4], dl);           /* mov [ebp-0x4], dl */
            ii(0x100c_0852, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100c_0855, 3); mov(memd[ss, ebp - 0xc], ecx);          /* mov [ebp-0xc], ecx */
            ii(0x100c_0858, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_085b, 5); call(0x1007_6338, -0x4_a528);           /* call 0x10076338 */
            ii(0x100c_0860, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_0862, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_0865, 5); call(0x1007_64b8, -0x4_a3b2);           /* call 0x100764b8 */
            ii(0x100c_086a, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_0871, 2); jmp(0x100c_087b, 0x8); goto l_0x100c_087b; /* jmp 0x100c087b */
        l_0x100c_0873:
            ii(0x100c_0873, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_0876, 5); call(0x1007_6bf8, -0x4_9c83);           /* call 0x10076bf8 */
        l_0x100c_087b:
            ii(0x100c_087b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_087d, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_0880, 5); call(0x1013_ad71, 0x7_a4ec);            /* call 0x1013ad71 */
            ii(0x100c_0885, 2); test(al, al);                           /* test al, al */
            ii(0x100c_0887, 2); if(jz(0x100c_08b7, 0x2e)) goto l_0x100c_08b7; /* jz 0x100c08b7 */
            ii(0x100c_0889, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_088c, 5); call(0x1007_63a0, -0x4_a4f1);           /* call 0x100763a0 */
            ii(0x100c_0891, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_0893, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x100c_0896, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100c_089a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_089c, 2); if(jnz(0x100c_08b5, 0x17)) goto l_0x100c_08b5; /* jnz 0x100c08b5 */
            ii(0x100c_089e, 4); movsx(ebx, memb[ss, ebp - 0x4]);        /* movsx ebx, byte [ebp-0x4] */
            ii(0x100c_08a2, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_08a5, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_08a8, 5); call(0x1007_63d4, -0x4_a4d9);           /* call 0x100763d4 */
            ii(0x100c_08ad, 5); call(0x100c_0780, -0x132);              /* call 0x100c0780 */
            ii(0x100c_08b2, 3); add(memd[ss, ebp - 0x18], eax);         /* add [ebp-0x18], eax */
        l_0x100c_08b5:
            ii(0x100c_08b5, 2); jmp(0x100c_0873, -0x44); goto l_0x100c_0873; /* jmp 0x100c0873 */
        l_0x100c_08b7:
            ii(0x100c_08b7, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_08ba, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_08bd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_08bf, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_08c2, 5); call(0x1007_5f6c, -0x4_a95b);           /* call 0x10075f6c */
            ii(0x100c_08c7, 2); jmp(0x100c_08d3, 0xa); goto l_0x100c_08d3; /* jmp 0x100c08d3 */
        //  ii(0x100c_08c9, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100c_08cb, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
        //  ii(0x100c_08ce, 5); call(0x1007_5f6c, -0x4_a967);           /* call 0x10075f6c */
        l_0x100c_08d3:
            ii(0x100c_08d3, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_08d6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_08d8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_08d9, 1); pop(edi);                               /* pop edi */
            ii(0x100c_08da, 1); pop(esi);                               /* pop esi */
            ii(0x100c_08db, 1); ret();                                  /* ret */
        }
    }
}
