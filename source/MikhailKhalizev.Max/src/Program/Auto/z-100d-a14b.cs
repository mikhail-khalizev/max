using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_a14b-365a8cf6")]
        public void Method_100d_a14b()
        {
            ii(0x100d_a14b, 5); push(0x28);                             /* push 0x28 */
            ii(0x100d_a150, 5); call(Definitions.sys_check_available_stack_size, 0x8_bbfd); /* call 0x10165d52 */
            ii(0x100d_a155, 1); push(ebx);                              /* push ebx */
            ii(0x100d_a156, 1); push(ecx);                              /* push ecx */
            ii(0x100d_a157, 1); push(esi);                              /* push esi */
            ii(0x100d_a158, 1); push(edi);                              /* push edi */
            ii(0x100d_a159, 1); push(ebp);                              /* push ebp */
            ii(0x100d_a15a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_a15c, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100d_a162, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_a165, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_a168, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100d_a16c, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100d_a16f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_a171, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a174, 5); add(eax, 0x1cf);                        /* add eax, 0x1cf */
            ii(0x100d_a179, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_a17b, 5); call(0x1007_6730, -0x6_3a50);           /* call 0x10076730 */
            ii(0x100d_a180, 3); mov(eax, memd[ds, eax + 23]);           /* mov eax, [eax+0x17] */
            ii(0x100d_a183, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_a186, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_a188, 6); if(jz(0x100d_a205, 0x77)) goto l_0x100d_a205; /* jz 0x100da205 */
            ii(0x100d_a18e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_a191, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100d_a194, 2); jmp(0x100d_a1a0, 0xa); goto l_0x100d_a1a0; /* jmp 0x100da1a0 */
        l_0x100d_a196:
            ii(0x100d_a196, 5); jmp(0x100d_a1fd, 0x62); goto l_0x100d_a1fd; /* jmp 0x100da1fd */
        l_0x100d_a19b:
            ii(0x100d_a19b, 5); jmp(0x100d_a205, 0x65); goto l_0x100d_a205; /* jmp 0x100da205 */
        l_0x100d_a1a0:
            ii(0x100d_a1a0, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_a1a3, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100d_a1a6, 5); cmp(memw[ss, ebp - 16], 0x3c);          /* cmp word [ebp-0x10], 0x3c */
            ii(0x100d_a1ab, 2); if(jb(0x100d_a1d4, 0x27)) goto l_0x100d_a1d4; /* jb 0x100da1d4 */
            ii(0x100d_a1ad, 5); cmp(memw[ss, ebp - 16], 0x3c);          /* cmp word [ebp-0x10], 0x3c */
            ii(0x100d_a1b2, 2); if(jbe(0x100d_a196, -0x1e)) goto l_0x100d_a196; /* jbe 0x100da196 */
            ii(0x100d_a1b4, 5); cmp(memw[ss, ebp - 16], 0x40);          /* cmp word [ebp-0x10], 0x40 */
            ii(0x100d_a1b9, 2); if(jb(0x100d_a1cb, 0x10)) goto l_0x100d_a1cb; /* jb 0x100da1cb */
            ii(0x100d_a1bb, 5); cmp(memw[ss, ebp - 16], 0x40);          /* cmp word [ebp-0x10], 0x40 */
            ii(0x100d_a1c0, 2); if(jbe(0x100d_a196, -0x2c)) goto l_0x100d_a196; /* jbe 0x100da196 */
            ii(0x100d_a1c2, 5); cmp(memw[ss, ebp - 16], 0x4b);          /* cmp word [ebp-0x10], 0x4b */
            ii(0x100d_a1c7, 2); if(jz(0x100d_a196, -0x33)) goto l_0x100d_a196; /* jz 0x100da196 */
            ii(0x100d_a1c9, 2); jmp(0x100d_a19b, -0x30); goto l_0x100d_a19b; /* jmp 0x100da19b */
        l_0x100d_a1cb:
            ii(0x100d_a1cb, 5); cmp(memw[ss, ebp - 16], 0x3d);          /* cmp word [ebp-0x10], 0x3d */
            ii(0x100d_a1d0, 2); if(jz(0x100d_a196, -0x3c)) goto l_0x100d_a196; /* jz 0x100da196 */
            ii(0x100d_a1d2, 2); jmp(0x100d_a19b, -0x39); goto l_0x100d_a19b; /* jmp 0x100da19b */
        l_0x100d_a1d4:
            ii(0x100d_a1d4, 5); cmp(memw[ss, ebp - 16], 0x31);          /* cmp word [ebp-0x10], 0x31 */
            ii(0x100d_a1d9, 2); if(jb(0x100d_a1eb, 0x10)) goto l_0x100d_a1eb; /* jb 0x100da1eb */
            ii(0x100d_a1db, 5); cmp(memw[ss, ebp - 16], 0x31);          /* cmp word [ebp-0x10], 0x31 */
            ii(0x100d_a1e0, 2); if(jbe(0x100d_a196, -0x4c)) goto l_0x100d_a196; /* jbe 0x100da196 */
            ii(0x100d_a1e2, 5); cmp(memw[ss, ebp - 16], 0x3b);          /* cmp word [ebp-0x10], 0x3b */
            ii(0x100d_a1e7, 2); if(jz(0x100d_a196, -0x53)) goto l_0x100d_a196; /* jz 0x100da196 */
            ii(0x100d_a1e9, 2); jmp(0x100d_a19b, -0x50); goto l_0x100d_a19b; /* jmp 0x100da19b */
        l_0x100d_a1eb:
            ii(0x100d_a1eb, 5); cmp(memw[ss, ebp - 16], 6);             /* cmp word [ebp-0x10], 0x6 */
            ii(0x100d_a1f0, 2); if(jb(0x100d_a1fb, 9)) goto l_0x100d_a1fb; /* jb 0x100da1fb */
            ii(0x100d_a1f2, 5); cmp(memw[ss, ebp - 16], 8);             /* cmp word [ebp-0x10], 0x8 */
            ii(0x100d_a1f7, 2); if(jbe(0x100d_a196, -0x63)) goto l_0x100d_a196; /* jbe 0x100da196 */
            ii(0x100d_a1f9, 2); jmp(0x100d_a19b, -0x60); goto l_0x100d_a19b; /* jmp 0x100da19b */
        l_0x100d_a1fb:
            ii(0x100d_a1fb, 2); jmp(0x100d_a19b, -0x62); goto l_0x100d_a19b; /* jmp 0x100da19b */
        l_0x100d_a1fd:
            ii(0x100d_a1fd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_a200, 5); add(memw[ds, eax + 83], 0x13);          /* add word [eax+0x53], 0x13 */
        l_0x100d_a205:
            ii(0x100d_a205, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_a207, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_a208, 1); pop(edi);                               /* pop edi */
            ii(0x100d_a209, 1); pop(esi);                               /* pop esi */
            ii(0x100d_a20a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_a20b, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_a20c, 1); ret();                                  /* ret */
        }
    }
}
