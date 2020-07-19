using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_756a-a2207446")]
        public void Method_1014_756a()
        {
            ii(0x1014_756a, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1014_756f, 5);  call(Definitions.sys_check_available_stack_size, 0x1_e7de);/* call 0x10165d52 */
            ii(0x1014_7574, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_7575, 1);  push(esi);                            /* push esi */
            ii(0x1014_7576, 1);  push(edi);                            /* push edi */
            ii(0x1014_7577, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_7578, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_757a, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1014_7580, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_7583, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1014_7586, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1014_7589, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_758c, 5);  call(0x1014_7395, -0x1fc);            /* call 0x10147395 */
            ii(0x1014_7591, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_7594, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1014_7596, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7599, 5);  call(/* sys */ 0x1018_0f4d, 0x3_99af);/* call 0x10180f4d */
            ii(0x1014_759e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_75a1, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1014_75a3, 5);  mov(eax, 0xa);                        /* mov eax, 0xa */
            ii(0x1014_75a8, 5);  call(/* sys */ 0x1017_29f1, 0x2_b444);/* call 0x101729f1 */
            ii(0x1014_75ad, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_75b0, 5);  call(0x1014_7395, -0x220);            /* call 0x10147395 */
            ii(0x1014_75b5, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_75b8, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1014_75ba, 5);  mov(eax, StringDefinitions.Less2);    /* mov eax, 0x101ad130 */
            ii(0x1014_75bf, 5);  call(/* sys */ 0x1018_0f4d, 0x3_9989);/* call 0x10180f4d */
            ii(0x1014_75c4, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_75c7, 5);  add(memw[ds, eax + 14], 2);           /* add word [eax+0xe], 0x2 */
            ii(0x1014_75cc, 4);  cmp(memd[ss, ebp - 4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1014_75d0, 2);  if(jnz(0x1014_75e6, 0x14)) goto l_0x1014_75e6;/* jnz 0x101475e6 */
            ii(0x1014_75d2, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1014_75d4, 5);  mov(edx, StringDefinitions.Index2);   /* mov edx, 0x101ad133 */
            ii(0x1014_75d9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_75dc, 5);  call(0x1014_74f5, -0xec);             /* call 0x101474f5 */
            ii(0x1014_75e1, 5);  jmp(0x1014_7664, 0x7e); goto l_0x1014_7664;/* jmp 0x10147664 */
        l_0x1014_75e6:
            ii(0x1014_75e6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_75e9, 5);  call(0x1013_c898, -0xad56);           /* call 0x1013c898 */
            ii(0x1014_75ee, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_75f1, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1014_75f3, 4);  mov(ax, memw[ss, ebp - 16]);          /* mov ax, [ebp-0x10] */
            ii(0x1014_75f7, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1014_75f9, 2);  if(jle(0x1014_7610, 0x15)) goto l_0x1014_7610;/* jle 0x10147610 */
            ii(0x1014_75fb, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1014_75fd, 4);  mov(bx, memw[ss, ebp - 16]);          /* mov bx, [ebp-0x10] */
            ii(0x1014_7601, 5);  mov(edx, StringDefinitions.Index3);   /* mov edx, 0x101ad139 */
            ii(0x1014_7606, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_7609, 5);  call(0x1014_74f5, -0x119);            /* call 0x101474f5 */
            ii(0x1014_760e, 2);  jmp(0x1014_7664, 0x54); goto l_0x1014_7664;/* jmp 0x10147664 */
        l_0x1014_7610:
            ii(0x1014_7610, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_7613, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1014_7616, 5);  call(0x1007_6b90, -0xd_0a8b);         /* call 0x10076b90 */
            ii(0x1014_761b, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1014_761e, 1);  inc(ebx);                             /* inc ebx */
            ii(0x1014_761f, 5);  mov(edx, StringDefinitions.Index4);   /* mov edx, 0x101ad13f */
            ii(0x1014_7624, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_7627, 5);  call(0x1014_74f5, -0x137);            /* call 0x101474f5 */
            ii(0x1014_762c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_762f, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_7632, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_7635, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1014_7638, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_763b, 3);  call_abs(memd[ds, edx + 4]);          /* call dword [edx+0x4] */
            ii(0x1014_763e, 1);  dec(eax);                             /* dec eax */
            ii(0x1014_763f, 1);  cwde();                               /* cwde */
            ii(0x1014_7640, 5);  call(0x1014_6820, -0xe25);            /* call 0x10146820 */
            ii(0x1014_7645, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1014_7647, 5);  mov(edx, StringDefinitions.Type6);    /* mov edx, 0x101ad145 */
            ii(0x1014_764c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_764f, 5);  call(0x1014_7489, -0x1cb);            /* call 0x10147489 */
            ii(0x1014_7654, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1014_7657, 5);  mov(edx, StringDefinitions.Object2);  /* mov edx, 0x101ad14a */
            ii(0x1014_765c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_765f, 5);  call(0x1014_768a, 0x26);              /* call 0x1014768a */
        l_0x1014_7664:
            ii(0x1014_7664, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_7667, 5);  sub(memw[ds, eax + 14], 2);           /* sub word [eax+0xe], 0x2 */
            ii(0x1014_766c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_766f, 5);  call(0x1014_7395, -0x2df);            /* call 0x10147395 */
            ii(0x1014_7674, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_7677, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1014_7679, 5);  mov(eax, StringDefinitions.Greater2); /* mov eax, 0x101ad151 */
            ii(0x1014_767e, 5);  call(/* sys */ 0x1018_0f4d, 0x3_98ca);/* call 0x10180f4d */
            ii(0x1014_7683, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_7685, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_7686, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_7687, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_7688, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_7689, 1);  ret();                                /* ret */
        }
    }
}
