using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_5281-b88bcbf")]
        public void Method_1010_5281()
        {
            ii(0x1010_5281, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1010_5286, 5);  call(Definitions.sys_check_available_stack_size, 0x6_0ac7);/* call 0x10165d52 */
            ii(0x1010_528b, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_528c, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_528d, 1);  push(edx);                            /* push edx */
            ii(0x1010_528e, 1);  push(esi);                            /* push esi */
            ii(0x1010_528f, 1);  push(edi);                            /* push edi */
            ii(0x1010_5290, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_5291, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_5293, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1010_5299, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_529c, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_529f, 3);  add(edx, 0x17);                       /* add edx, 0x17 */
            ii(0x1010_52a2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_52a5, 6);  mov(eax, memd[ds, eax + 1122]);       /* mov eax, [eax+0x462] */
            ii(0x1010_52ab, 5);  call(0x100d_7f6c, -0x2_d344);         /* call 0x100d7f6c */
            ii(0x1010_52b0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_52b3, 3);  mov(edx, memd[ds, eax + 37]);         /* mov edx, [eax+0x25] */
            ii(0x1010_52b6, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_52b9, 3);  imul(edx, edx, 0x14);                 /* imul edx, edx, 0x14 */
            ii(0x1010_52bc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_52bf, 3);  mov(eax, memd[ds, eax + 45]);         /* mov eax, [eax+0x2d] */
            ii(0x1010_52c2, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x1010_52c5, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1010_52c7, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_52ca, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x1010_52d0, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1010_52d2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_52d5, 7);  mov(ax, memw[ds, eax + 1128]);        /* mov ax, [eax+0x468] */
            ii(0x1010_52dc, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1010_52df, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_52e2, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_52e6, 5);  cmp(eax, 0xa0);                       /* cmp eax, 0xa0 */
            ii(0x1010_52eb, 2);  if(jge(0x1010_5312, 0x25)) goto l_0x1010_5312;/* jge 0x10105312 */
            ii(0x1010_52ed, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1010_52f1, 5);  mov(eax, 0xa0);                       /* mov eax, 0xa0 */
            ii(0x1010_52f6, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1010_52f8, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1010_52fa, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1010_52fc, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1010_52ff, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1010_5301, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1010_5303, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_5306, 3);  mov(edx, memd[ds, edx + 37]);         /* mov edx, [edx+0x25] */
            ii(0x1010_5309, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_530c, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1010_530f, 3);  add(memd[ss, ebp - 20], eax);         /* add [ebp-0x14], eax */
        l_0x1010_5312:
            ii(0x1010_5312, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_5315, 7);  mov(ax, memw[ds, eax + 1130]);        /* mov ax, [eax+0x46a] */
            ii(0x1010_531c, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_531f, 7);  add(ax, memw[ds, edx + 1126]);        /* add ax, [edx+0x466] */
            ii(0x1010_5326, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_5329, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_532c, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_532f, 7);  cmp(ax, memw[ds, edx + 1128]);        /* cmp ax, [edx+0x468] */
            ii(0x1010_5336, 2);  if(jle(0x1010_5345, 0xd)) goto l_0x1010_5345;/* jle 0x10105345 */
            ii(0x1010_5338, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_533b, 7);  mov(ax, memw[ds, eax + 1128]);        /* mov ax, [eax+0x468] */
            ii(0x1010_5342, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1010_5345:
            ii(0x1010_5345, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1010_534a, 5);  call(/* sys */ 0x1016_a24c, 0x6_4efd);/* call 0x1016a24c */
            ii(0x1010_534f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_5352, 7);  mov(ax, memw[ds, eax + 1130]);        /* mov ax, [eax+0x46a] */
            ii(0x1010_5359, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_535c, 2);  jmp(0x1010_5364, 6); goto l_0x1010_5364;/* jmp 0x10105364 */
        l_0x1010_535e:
            ii(0x1010_535e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_5361, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1010_5364:
            ii(0x1010_5364, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_5367, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x1010_536b, 2);  if(jge(0x1010_53cf, 0x62)) goto l_0x1010_53cf;/* jge 0x101053cf */
            ii(0x1010_536d, 5);  push(0x1_00ff);                       /* push 0x100ff */
            ii(0x1010_5372, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_5375, 3);  mov(ecx, memd[ds, eax + 37]);         /* mov ecx, [eax+0x25] */
            ii(0x1010_5378, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1010_537b, 5);  mov(ebx, 0x109);                      /* mov ebx, 0x109 */
            ii(0x1010_5380, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_5384, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_5387, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1010_5389, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_538c, 6);  mov(eax, memd[ds, eax + 1132]);       /* mov eax, [eax+0x46c] */
            ii(0x1010_5392, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1010_5394, 5);  call(Definitions.my_strobj_c_str_v2, -0x7_bbd1);/* call 0x100897c8 */
            ii(0x1010_5399, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1010_539b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_539e, 6);  mov(esi, memd[ds, eax + 1128]);       /* mov esi, [eax+0x468] */
            ii(0x1010_53a4, 3);  sar(esi, 0x10);                       /* sar esi, 0x10 */
            ii(0x1010_53a7, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_53ab, 2);  sub(eax, esi);                        /* sub eax, esi */
            ii(0x1010_53ad, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1010_53af, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x1010_53b5, 3);  imul(esi, eax);                       /* imul esi, eax */
            ii(0x1010_53b8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_53bb, 3);  mov(eax, memd[ds, eax + 37]);         /* mov eax, [eax+0x25] */
            ii(0x1010_53be, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_53c1, 3);  imul(eax, esi);                       /* imul eax, esi */
            ii(0x1010_53c4, 3);  add(eax, memd[ss, ebp - 20]);         /* add eax, [ebp-0x14] */
            ii(0x1010_53c7, 6);  call_abs(memd[ds, 0x101b_ddec]);      /* call dword [0x101bddec] */
            ii(0x1010_53cd, 2);  jmp(0x1010_535e, -0x71); goto l_0x1010_535e;/* jmp 0x1010535e */
        l_0x1010_53cf:
            ii(0x1010_53cf, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_53d2, 3);  add(edx, 0x17);                       /* add edx, 0x17 */
            ii(0x1010_53d5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_53d8, 3);  mov(eax, memd[ds, eax + 41]);         /* mov eax, [eax+0x29] */
            ii(0x1010_53db, 5);  call(Definitions.sys_display_draw_1, 0x6_20c8);/* call 0x101674a8 */
            ii(0x1010_53e0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_53e2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_53e3, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_53e4, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_53e5, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_53e6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_53e7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_53e8, 1);  ret();                                /* ret */
        }
    }
}
