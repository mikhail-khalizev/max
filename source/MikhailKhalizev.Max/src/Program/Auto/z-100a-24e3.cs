using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_24e3-b39006b2")]
        public void Method_100a_24e3()
        {
            ii(0x100a_24e3, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100a_24e8, 5); call(Definitions.sys_check_available_stack_size, 0xc_3865); /* call 0x10165d52 */
            ii(0x100a_24ed, 1); push(ecx);                              /* push ecx */
            ii(0x100a_24ee, 1); push(esi);                              /* push esi */
            ii(0x100a_24ef, 1); push(edi);                              /* push edi */
            ii(0x100a_24f0, 1); push(ebp);                              /* push ebp */
            ii(0x100a_24f1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_24f3, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100a_24f9, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_24fc, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100a_24ff, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100a_2502, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_2505, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100a_250a, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100a_250d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_2510, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100a_2515, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100a_2518, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_251b, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100a_251e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_2521, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_2524, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x100a_2527, 1); cwde();                                 /* cwde */
            ii(0x100a_2528, 5); call(0x100a_2466, -0xc7);               /* call 0x100a2466 */
            ii(0x100a_252d, 2); test(al, al);                           /* test al, al */
            ii(0x100a_252f, 2); if(jnz(0x100a_253a, 0x9)) goto l_0x100a_253a; /* jnz 0x100a253a */
            ii(0x100a_2531, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_2535, 5); jmp(0x100a_25db, 0xa1); goto l_0x100a_25db; /* jmp 0x100a25db */
        l_0x100a_253a:
            ii(0x100a_253a, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100a_2541, 2); jmp(0x100a_2549, 0x6); goto l_0x100a_2549; /* jmp 0x100a2549 */
        l_0x100a_2543:
            ii(0x100a_2543, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_2546, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
        l_0x100a_2549:
            ii(0x100a_2549, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100a_254d, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100a_2550, 6); if(jge(0x100a_25d7, 0x81)) goto l_0x100a_25d7; /* jge 0x100a25d7 */
            ii(0x100a_2556, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_2559, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100a_255d, 2); if(jz(0x100a_2577, 0x18)) goto l_0x100a_2577; /* jz 0x100a2577 */
            ii(0x100a_255f, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100a_2563, 3); imul(edx, eax, 0x13);                   /* imul edx, eax, 0x13 */
            ii(0x100a_2566, 5); mov(eax, 0x101c_35b4);                  /* mov eax, 0x101c35b4 */
            ii(0x100a_256b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_256d, 5); call(Definitions.my_2_get_count, -0x1_720a); /* call 0x1008b368 */
            ii(0x100a_2572, 1); cwde();                                 /* cwde */
            ii(0x100a_2573, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_2575, 2); if(jg(0x100a_2579, 0x2)) goto l_0x100a_2579; /* jg 0x100a2579 */
        l_0x100a_2577:
            ii(0x100a_2577, 2); jmp(0x100a_25d2, 0x59); goto l_0x100a_25d2; /* jmp 0x100a25d2 */
        l_0x100a_2579:
            ii(0x100a_2579, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_257c, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_ba91); /* call 0x10076af0 */
            ii(0x100a_2581, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100a_2585, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100a_2588, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_258b, 7); sub(ax, memw[ds, edx + 0x101c_35bc]);   /* sub ax, [edx+0x101c35bc] */
            ii(0x100a_2592, 4); mov(memw[ss, ebp - 0x18], ax);          /* mov [ebp-0x18], ax */
            ii(0x100a_2596, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100a_259a, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100a_259d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_25a0, 7); sub(ax, memw[ds, edx + 0x101c_35be]);   /* sub ax, [edx+0x101c35be] */
            ii(0x100a_25a7, 4); mov(memw[ss, ebp - 0x16], ax);          /* mov [ebp-0x16], ax */
            ii(0x100a_25ab, 4); movsx(edx, memw[ss, ebp - 0x16]);       /* movsx edx, word [ebp-0x16] */
            ii(0x100a_25af, 4); movsx(eax, memw[ss, ebp - 0x16]);       /* movsx eax, word [ebp-0x16] */
            ii(0x100a_25b3, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100a_25b6, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100a_25b8, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100a_25bc, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100a_25c0, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100a_25c3, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_25c5, 5); cmp(eax, 0x190);                        /* cmp eax, 0x190 */
            ii(0x100a_25ca, 2); if(jge(0x100a_25d2, 0x6)) goto l_0x100a_25d2; /* jge 0x100a25d2 */
            ii(0x100a_25cc, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x100a_25d0, 2); jmp(0x100a_25db, 0x9); goto l_0x100a_25db; /* jmp 0x100a25db */
        l_0x100a_25d2:
            ii(0x100a_25d2, 5); jmp(0x100a_2543, -0x94); goto l_0x100a_2543; /* jmp 0x100a2543 */
        l_0x100a_25d7:
            ii(0x100a_25d7, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
        l_0x100a_25db:
            ii(0x100a_25db, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x100a_25de, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_25e0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_25e1, 1); pop(edi);                               /* pop edi */
            ii(0x100a_25e2, 1); pop(esi);                               /* pop esi */
            ii(0x100a_25e3, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_25e4, 1); ret();                                  /* ret */
        }
    }
}
