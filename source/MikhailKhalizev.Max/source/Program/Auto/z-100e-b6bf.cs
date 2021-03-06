using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_b6bf-243096bf")]
        public void Method_100e_b6bf()
        {
            ii(0x100e_b6bf, 5);  push(0x34);                           /* push 0x34 */
            ii(0x100e_b6c4, 5);  call(Definitions.sys_check_available_stack_size, 0x7_a689);/* call 0x10165d52 */
            ii(0x100e_b6c9, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_b6ca, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_b6cb, 1);  push(edx);                            /* push edx */
            ii(0x100e_b6cc, 1);  push(esi);                            /* push esi */
            ii(0x100e_b6cd, 1);  push(edi);                            /* push edi */
            ii(0x100e_b6ce, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_b6cf, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_b6d1, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100e_b6d7, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_b6da, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b6dd, 4);  cmp(memb[ds, eax + 43], 0);           /* cmp byte [eax+0x2b], 0x0 */
            ii(0x100e_b6e1, 2);  if(jnz(0x100e_b6f5, 0x12)) goto l_0x100e_b6f5;/* jnz 0x100eb6f5 */
            ii(0x100e_b6e3, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100e_b6e8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b6eb, 5);  call(0x100e_b5e1, -0x10f);            /* call 0x100eb5e1 */
            ii(0x100e_b6f0, 5);  jmp(0x100e_b7c0, 0xcb); goto l_0x100e_b7c0;/* jmp 0x100eb7c0 */
        l_0x100e_b6f5:
            ii(0x100e_b6f5, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x100e_b6f8, 3);  mov(ebx, memd[ds, ebx + 42]);         /* mov ebx, [ebx+0x2a] */
            ii(0x100e_b6fb, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100e_b6fe, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b701, 3);  mov(edx, memd[ds, eax + 35]);         /* mov edx, [eax+0x23] */
            ii(0x100e_b704, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b707, 3);  mov(eax, memd[ds, eax + 39]);         /* mov eax, [eax+0x27] */
            ii(0x100e_b70a, 5);  call(Definitions.sys_strncpy, 0x8_67d1);/* call 0x10171ee0 */
            ii(0x100e_b70f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b712, 3);  mov(edx, memd[ds, eax + 42]);         /* mov edx, [eax+0x2a] */
            ii(0x100e_b715, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100e_b718, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b71b, 3);  mov(eax, memd[ds, eax + 39]);         /* mov eax, [eax+0x27] */
            ii(0x100e_b71e, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100e_b720, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
            ii(0x100e_b723, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b726, 3);  mov(eax, memd[ds, eax + 49]);         /* mov eax, [eax+0x31] */
            ii(0x100e_b729, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_b72c, 5);  call(/* sys */ 0x1016_a24c, 0x7_eb1b);/* call 0x1016a24c */
            ii(0x100e_b731, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b734, 3);  mov(eax, memd[ds, eax + 39]);         /* mov eax, [eax+0x27] */
            ii(0x100e_b737, 6);  call_abs(memd[ds, 0x101b_ddf4]);      /* call dword [0x101bddf4] */
            ii(0x100e_b73d, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_b740, 5);  mov(eax, StringDefinitions.Control3); /* mov eax, 0x101a1efc */
            ii(0x100e_b745, 6);  call_abs(memd[ds, 0x101b_ddf4]);      /* call dword [0x101bddf4] */
            ii(0x100e_b74b, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x100e_b74e, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100e_b750, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100e_b753, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100e_b75a, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x100e_b760, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_b763, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b766, 3);  mov(eax, memd[ds, eax + 46]);         /* mov eax, [eax+0x2e] */
            ii(0x100e_b769, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_b76c, 1);  push(eax);                            /* push eax */
            ii(0x100e_b76d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b770, 3);  mov(ecx, memd[ds, eax + 14]);         /* mov ecx, [eax+0xe] */
            ii(0x100e_b773, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100e_b776, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x100e_b779, 3);  sub(ebx, memd[ss, ebp - 20]);         /* sub ebx, [ebp-0x14] */
            ii(0x100e_b77c, 5);  mov(edx, StringDefinitions.Control4); /* mov edx, 0x101a1efe */
            ii(0x100e_b781, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b784, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x100e_b787, 3);  add(eax, memd[ss, ebp - 20]);         /* add eax, [ebp-0x14] */
            ii(0x100e_b78a, 6);  call_abs(memd[ds, 0x101b_ddec]);      /* call dword [0x101bddec] */
            ii(0x100e_b790, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b793, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100e_b795, 3);  add(memd[ss, ebp - 20], eax);         /* add [ebp-0x14], eax */
            ii(0x100e_b798, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b79b, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100e_b79d, 3);  add(memd[ss, ebp - 12], eax);         /* add [ebp-0xc], eax */
            ii(0x100e_b7a0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b7a3, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100e_b7a6, 3);  add(memd[ss, ebp - 16], eax);         /* add [ebp-0x10], eax */
            ii(0x100e_b7a9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b7ac, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100e_b7af, 3);  add(memd[ss, ebp - 8], eax);          /* add [ebp-0x8], eax */
            ii(0x100e_b7b2, 3);  lea(edx, memd[ss, ebp - 20]);         /* lea edx, [ebp-0x14] */
            ii(0x100e_b7b5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b7b8, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x100e_b7bb, 5);  call(Definitions.sys_display_draw_1, 0x7_bce8);/* call 0x101674a8 */
        l_0x100e_b7c0:
            ii(0x100e_b7c0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_b7c2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_b7c3, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_b7c4, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_b7c5, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_b7c6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_b7c7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_b7c8, 1);  ret();                                /* ret */
        }
    }
}
