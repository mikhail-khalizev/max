using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_e381-d6e81f8b")]
        public void Method_1010_e381()
        {
            ii(0x1010_e381, 5); push(0x34);                             /* push 0x34 */
            ii(0x1010_e386, 5); call(Definitions.sys_check_available_stack_size, 0x5_79c7); /* call 0x10165d52 */
            ii(0x1010_e38b, 1); push(ebx);                              /* push ebx */
            ii(0x1010_e38c, 1); push(ecx);                              /* push ecx */
            ii(0x1010_e38d, 1); push(edx);                              /* push edx */
            ii(0x1010_e38e, 1); push(esi);                              /* push esi */
            ii(0x1010_e38f, 1); push(edi);                              /* push edi */
            ii(0x1010_e390, 1); push(ebp);                              /* push ebp */
            ii(0x1010_e391, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_e393, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_e399, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_e39c, 7); mov(memd[ss, ebp - 0x10], 0x4);         /* mov dword [ebp-0x10], 0x4 */
            ii(0x1010_e3a3, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1010_e3aa, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
        l_0x1010_e3b1:
            ii(0x1010_e3b1, 3); dec(memd[ss, ebp - 0x10]);              /* dec dword [ebp-0x10] */
            ii(0x1010_e3b4, 5); cmp(memw[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x1010_e3b9, 2); if(jz(0x1010_e3ed, 0x32)) goto l_0x1010_e3ed; /* jz 0x1010e3ed */
            ii(0x1010_e3bb, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1010_e3be, 2); add(al, 0x67);                          /* add al, 0x67 */
            ii(0x1010_e3c0, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1010_e3c3, 5); call(0x1007_5fdc, -0x9_83ec);           /* call 0x10075fdc */
            ii(0x1010_e3c8, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_e3cb, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1010_e3cf, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1010_e3d2, 2); if(jnz(0x1010_e3dc, 0x8)) goto l_0x1010_e3dc; /* jnz 0x1010e3dc */
            ii(0x1010_e3d4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_e3d7, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
            ii(0x1010_e3da, 2); jmp(0x1010_e3eb, 0xf); goto l_0x1010_e3eb; /* jmp 0x1010e3eb */
        l_0x1010_e3dc:
            ii(0x1010_e3dc, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1010_e3e0, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1010_e3e3, 2); if(jnz(0x1010_e3eb, 0x6)) goto l_0x1010_e3eb; /* jnz 0x1010e3eb */
            ii(0x1010_e3e5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_e3e8, 3); inc(memd[ss, ebp - 0x8]);               /* inc dword [ebp-0x8] */
        l_0x1010_e3eb:
            ii(0x1010_e3eb, 2); jmp(0x1010_e3b1, -0x3c); goto l_0x1010_e3b1; /* jmp 0x1010e3b1 */
        l_0x1010_e3ed:
            ii(0x1010_e3ed, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_e3f0, 4); cmp(memd[ds, eax + 0xc], 0);            /* cmp dword [eax+0xc], 0x0 */
            ii(0x1010_e3f4, 2); if(jz(0x1010_e436, 0x40)) goto l_0x1010_e436; /* jz 0x1010e436 */
            ii(0x1010_e3f6, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1010_e3fa, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_e3fe, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_e400, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1010_e403, 2); if(jl(0x1010_e411, 0xc)) goto l_0x1010_e411; /* jl 0x1010e411 */
            ii(0x1010_e405, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_e408, 7); mov(memd[ds, eax + 0x4], 0x1);          /* mov dword [eax+0x4], 0x1 */
            ii(0x1010_e40f, 2); jmp(0x1010_e434, 0x23); goto l_0x1010_e434; /* jmp 0x1010e434 */
        l_0x1010_e411:
            ii(0x1010_e411, 5); call(0x100c_aa00, -0x4_3a16);           /* call 0x100caa00 */
            ii(0x1010_e416, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_e41b, 1); push(eax);                              /* push eax */
            ii(0x1010_e41c, 5); call(0x100c_aa20, -0x4_3a01);           /* call 0x100caa20 */
            ii(0x1010_e421, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1010_e423, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1010_e428, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_e42a, 5); mov(eax, StringDefinitions.ThereMustBeAtLeastTwoPlayersToBeginANewGame); /* mov eax, 0x101a45a3 */
            ii(0x1010_e42f, 5); call(0x1011_5d23, 0x78ef);              /* call 0x10115d23 */
        l_0x1010_e434:
            ii(0x1010_e434, 2); jmp(0x1010_e46e, 0x38); goto l_0x1010_e46e; /* jmp 0x1010e46e */
        l_0x1010_e436:
            ii(0x1010_e436, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_e43a, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1010_e43d, 2); if(jl(0x1010_e44b, 0xc)) goto l_0x1010_e44b; /* jl 0x1010e44b */
            ii(0x1010_e43f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_e442, 7); mov(memd[ds, eax + 0x4], 0x1);          /* mov dword [eax+0x4], 0x1 */
            ii(0x1010_e449, 2); jmp(0x1010_e46e, 0x23); goto l_0x1010_e46e; /* jmp 0x1010e46e */
        l_0x1010_e44b:
            ii(0x1010_e44b, 5); call(0x100c_aa00, -0x4_3a50);           /* call 0x100caa00 */
            ii(0x1010_e450, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_e455, 1); push(eax);                              /* push eax */
            ii(0x1010_e456, 5); call(0x100c_aa20, -0x4_3a3b);           /* call 0x100caa20 */
            ii(0x1010_e45b, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1010_e45d, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1010_e462, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_e464, 5); mov(eax, StringDefinitions.ThereMustBeAtLeastTwoHumanPlayersToBeginAHotSeatGame); /* mov eax, 0x101a45db */
            ii(0x1010_e469, 5); call(0x1011_5d23, 0x78b5);              /* call 0x10115d23 */
        l_0x1010_e46e:
            ii(0x1010_e46e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_e470, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_e471, 1); pop(edi);                               /* pop edi */
            ii(0x1010_e472, 1); pop(esi);                               /* pop esi */
            ii(0x1010_e473, 1); pop(edx);                               /* pop edx */
            ii(0x1010_e474, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_e475, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_e476, 1); ret();                                  /* ret */
        }
    }
}
