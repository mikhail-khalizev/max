using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_96e0-bb37322")]
        public void Method_1010_96e0()
        {
            ii(0x1010_96e0, 5);  push(0x40);                           /* push 0x40 */
            ii(0x1010_96e5, 5);  call(Definitions.sys_check_available_stack_size, 0x5_c668);/* call 0x10165d52 */
            ii(0x1010_96ea, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_96eb, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_96ec, 1);  push(edx);                            /* push edx */
            ii(0x1010_96ed, 1);  push(esi);                            /* push esi */
            ii(0x1010_96ee, 1);  push(edi);                            /* push edi */
            ii(0x1010_96ef, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_96f0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_96f2, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1010_96f8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_96fb, 7);  cmp(memd[ds, 0x101c_4ddc], 0);        /* cmp dword [0x101c4ddc], 0x0 */
            ii(0x1010_9702, 6);  if(jz(0x1010_97fb, 0xf3)) goto l_0x1010_97fb;/* jz 0x101097fb */
            ii(0x1010_9708, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_970b, 5);  call(0x1010_9688, -0x88);             /* call 0x10109688 */
            ii(0x1010_9710, 5);  mov(eax, 0x1a5);                      /* mov eax, 0x1a5 */
            ii(0x1010_9715, 1);  push(eax);                            /* push eax */
            ii(0x1010_9716, 5);  mov(ecx, 0x13b);                      /* mov ecx, 0x13b */
            ii(0x1010_971b, 5);  mov(ebx, 0xb9);                       /* mov ebx, 0xb9 */
            ii(0x1010_9720, 5);  mov(edx, 0x13);                       /* mov edx, 0x13 */
            ii(0x1010_9725, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1010_9728, 5);  call(0x1008_b148, -0x7_e5e5);         /* call 0x1008b148 */
            ii(0x1010_972d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_9730, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x1010_9733, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_9736, 3);  mov(edx, memd[ss, ebp - 28]);         /* mov edx, [ebp-0x1c] */
            ii(0x1010_9739, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1010_973c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_973f, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x1010_9742, 3);  add(eax, memd[ss, ebp - 32]);         /* add eax, [ebp-0x20] */
            ii(0x1010_9745, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1010_9747, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_974a, 6);  mov(ax, memw[ds, 0x101c_4dea]);       /* mov ax, [0x101c4dea] */
            ii(0x1010_9750, 7);  add(ax, memw[ds, 0x101c_4de8]);       /* add ax, [0x101c4de8] */
            ii(0x1010_9757, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_975a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_975d, 7);  cmp(ax, memw[ds, 0x101c_4dec]);       /* cmp ax, [0x101c4dec] */
            ii(0x1010_9764, 2);  if(jle(0x1010_976f, 9)) goto l_0x1010_976f;/* jle 0x1010976f */
            ii(0x1010_9766, 6);  mov(ax, memw[ds, 0x101c_4dec]);       /* mov ax, [0x101c4dec] */
            ii(0x1010_976c, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1010_976f:
            ii(0x1010_976f, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1010_9774, 5);  call(/* sys */ 0x1016_a24c, 0x6_0ad3);/* call 0x1016a24c */
            ii(0x1010_9779, 6);  mov(ax, memw[ds, 0x101c_4dea]);       /* mov ax, [0x101c4dea] */
            ii(0x1010_977f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_9782, 2);  jmp(0x1010_978a, 6); goto l_0x1010_978a;/* jmp 0x1010978a */
        l_0x1010_9784:
            ii(0x1010_9784, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_9787, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x1010_978a:
            ii(0x1010_978a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_978d, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x1010_9791, 2);  if(jge(0x1010_97ed, 0x5a)) goto l_0x1010_97ed;/* jge 0x101097ed */
            ii(0x1010_9793, 5);  push(0xa2);                           /* push 0xa2 */
            ii(0x1010_9798, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_979b, 3);  mov(ecx, memd[ds, eax + 14]);         /* mov ecx, [eax+0xe] */
            ii(0x1010_979e, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1010_97a1, 5);  mov(ebx, 0x128);                      /* mov ebx, 0x128 */
            ii(0x1010_97a6, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_97aa, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_97ad, 6);  mov(edx, memd[ds, 0x101c_4ddc]);      /* mov edx, [0x101c4ddc] */
            ii(0x1010_97b3, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1010_97b5, 5);  call(Definitions.my_strobj_c_str_v2, -0x7_fff2);/* call 0x100897c8 */
            ii(0x1010_97ba, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1010_97bc, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_97c0, 6);  mov(esi, memd[ds, 0x101c_4de8]);      /* mov esi, [0x101c4de8] */
            ii(0x1010_97c6, 3);  sar(esi, 0x10);                       /* sar esi, 0x10 */
            ii(0x1010_97c9, 2);  sub(eax, esi);                        /* sub eax, esi */
            ii(0x1010_97cb, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1010_97cd, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x1010_97d3, 3);  imul(esi, eax);                       /* imul esi, eax */
            ii(0x1010_97d6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_97d9, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x1010_97dc, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_97df, 3);  imul(eax, esi);                       /* imul eax, esi */
            ii(0x1010_97e2, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1010_97e5, 6);  call_abs(memd[ds, 0x101b_ddec]);      /* call dword [0x101bddec] */
            ii(0x1010_97eb, 2);  jmp(0x1010_9784, -0x69); goto l_0x1010_9784;/* jmp 0x10109784 */
        l_0x1010_97ed:
            ii(0x1010_97ed, 3);  lea(edx, memd[ss, ebp - 32]);         /* lea edx, [ebp-0x20] */
            ii(0x1010_97f0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_97f3, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1010_97f6, 5);  call(Definitions.sys_display_draw_1, 0x5_dcad);/* call 0x101674a8 */
        l_0x1010_97fb:
            ii(0x1010_97fb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_97fd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_97fe, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_97ff, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_9800, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_9801, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_9802, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_9803, 1);  ret();                                /* ret */
        }
    }
}
