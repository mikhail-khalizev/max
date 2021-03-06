using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_04d8-a07871f1")]
        public void Method_100f_04d8()
        {
            ii(0x100f_04d8, 5);  push(0x48);                           /* push 0x48 */
            ii(0x100f_04dd, 5);  call(Definitions.sys_check_available_stack_size, 0x7_5870);/* call 0x10165d52 */
            ii(0x100f_04e2, 1);  push(esi);                            /* push esi */
            ii(0x100f_04e3, 1);  push(edi);                            /* push edi */
            ii(0x100f_04e4, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_04e5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_04e7, 6);  sub(esp, 0x34);                       /* sub esp, 0x34 */
            ii(0x100f_04ed, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_04f0, 3);  mov(memd[ss, ebp - 16], edx);         /* mov [ebp-0x10], edx */
            ii(0x100f_04f3, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100f_04f6, 3);  mov(memd[ss, ebp - 12], ecx);         /* mov [ebp-0xc], ecx */
            ii(0x100f_04f9, 5);  mov(eax, 0x70);                       /* mov eax, 0x70 */
            ii(0x100f_04fe, 5);  call(Definitions.sys_malloc, 0x7_aadb);/* call 0x1016afde */
            ii(0x100f_0503, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_0506, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_0509, 6);  mov(memd[ds, eax], 0);                /* mov dword [eax], 0x0 */
            ii(0x100f_050f, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_0512, 7);  mov(memd[ds, eax + 72], 0);           /* mov dword [eax+0x48], 0x0 */
            ii(0x100f_0519, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100f_051d, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_0520, 3);  mov(memd[ds, edx + 80], eax);         /* mov [edx+0x50], eax */
            ii(0x100f_0523, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x100f_0527, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_052a, 3);  mov(memd[ds, edx + 84], eax);         /* mov [edx+0x54], eax */
            ii(0x100f_052d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_0530, 3);  mov(edx, memd[ds, eax + 18]);         /* mov edx, [eax+0x12] */
            ii(0x100f_0533, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_0536, 3);  mov(memd[ds, eax + 72], edx);         /* mov [eax+0x48], edx */
            ii(0x100f_0539, 4);  movsx(edx, memw[ss, ebp + 16]);       /* movsx edx, word [ebp+0x10] */
            ii(0x100f_053d, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_0541, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100f_0544, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100f_0548, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100f_054a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_054d, 3);  mov(ebx, memd[ds, eax + 22]);         /* mov ebx, [eax+0x16] */
            ii(0x100f_0550, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_0553, 2);  add(ebx, edx);                        /* add ebx, edx */
            ii(0x100f_0555, 3);  mov(memd[ds, eax + 76], ebx);         /* mov [eax+0x4c], ebx */
            ii(0x100f_0558, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_055b, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_055e, 4);  mov(memw[ds, edx + 105], ax);         /* mov [edx+0x69], ax */
            ii(0x100f_0562, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_0565, 6);  mov(memw[ds, eax + 103], 0);          /* mov word [eax+0x67], 0x0 */
            ii(0x100f_056b, 3);  mov(al, memb[ss, ebp + 20]);          /* mov al, [ebp+0x14] */
            ii(0x100f_056e, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_0571, 3);  mov(memb[ds, edx + 96], al);          /* mov [edx+0x60], al */
            ii(0x100f_0574, 3);  mov(al, memb[ss, ebp + 24]);          /* mov al, [ebp+0x18] */
            ii(0x100f_0577, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_057a, 3);  mov(memb[ds, edx + 111], al);         /* mov [edx+0x6f], al */
            ii(0x100f_057d, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100f_0584, 2);  jmp(0x100f_058c, 6); goto l_0x100f_058c;/* jmp 0x100f058c */
        l_0x100f_0586:
            ii(0x100f_0586, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_0589, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
        l_0x100f_058c:
            ii(0x100f_058c, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100f_0590, 3);  cmp(eax, 5);                          /* cmp eax, 0x5 */
            ii(0x100f_0593, 2);  if(jae(0x100f_05a8, 0x13)) goto l_0x100f_05a8;/* jae 0x100f05a8 */
            ii(0x100f_0595, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100f_0599, 3);  imul(eax, eax, 0xc);                  /* imul eax, eax, 0xc */
            ii(0x100f_059c, 3);  add(eax, memd[ss, ebp - 20]);         /* add eax, [ebp-0x14] */
            ii(0x100f_059f, 7);  mov(memd[ds, eax + 16], 0);           /* mov dword [eax+0x10], 0x0 */
            ii(0x100f_05a6, 2);  jmp(0x100f_0586, -0x22); goto l_0x100f_0586;/* jmp 0x100f0586 */
        l_0x100f_05a8:
            ii(0x100f_05a8, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_05ac, 5);  call(Definitions.my_get_res_data_by_id_malloc, 0x4_3c3a);/* call 0x101341eb */
            ii(0x100f_05b1, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100f_05b4, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x100f_05b7, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100f_05ba, 5);  call(0x100f_0439, -0x186);            /* call 0x100f0439 */
            ii(0x100f_05bf, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_05c1, 6);  if(jnz(0x100f_0645, 0x7e)) goto l_0x100f_0645;/* jnz 0x100f0645 */
            ii(0x100f_05c7, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100f_05cb, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100f_05ce, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x100f_05d2, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100f_05d5, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x100f_05d8, 5);  add(eax, 0x80);                       /* add eax, 0x80 */
            ii(0x100f_05dd, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x100f_05e0, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x100f_05e3, 5);  add(eax, 0x80);                       /* add eax, 0x80 */
            ii(0x100f_05e8, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100f_05eb, 2);  push(0);                              /* push 0x0 */
            ii(0x100f_05ed, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x100f_05f1, 5);  mov(ebx, 0x80);                       /* mov ebx, 0x80 */
            ii(0x100f_05f6, 5);  mov(edx, 0x80);                       /* mov edx, 0x80 */
            ii(0x100f_05fb, 4);  movsx(esi, memw[ss, ebp - 12]);       /* movsx esi, word [ebp-0xc] */
            ii(0x100f_05ff, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_0602, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x100f_0605, 2);  add(esi, eax);                        /* add esi, eax */
            ii(0x100f_0607, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x100f_060b, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100f_060e, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_0612, 4);  imul(eax, memd[ss, ebp - 48]);        /* imul eax, [ebp-0x30] */
            ii(0x100f_0616, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x100f_0618, 5);  call(/* sys */ 0x1016_ad78, 0x7_a75b);/* call 0x1016ad78 */
            ii(0x100f_061d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_0620, 4);  cmp(memd[ds, eax + 18], 0);           /* cmp dword [eax+0x12], 0x0 */
            ii(0x100f_0624, 2);  if(jz(0x100f_0634, 0xe)) goto l_0x100f_0634;/* jz 0x100f0634 */
            ii(0x100f_0626, 3);  lea(edx, memd[ss, ebp - 44]);         /* lea edx, [ebp-0x2c] */
            ii(0x100f_0629, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_062c, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x100f_062f, 5);  call(Definitions.sys_display_draw_1, 0x7_6e74);/* call 0x101674a8 */
        l_0x100f_0634:
            ii(0x100f_0634, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_0637, 5);  call(Definitions.sys_free, 0x7_aa85); /* call 0x1016b0c1 */
            ii(0x100f_063c, 7);  mov(memd[ss, ebp - 52], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x100f_0643, 2);  jmp(0x100f_0663, 0x1e); goto l_0x100f_0663;/* jmp 0x100f0663 */
        l_0x100f_0645:
            ii(0x100f_0645, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_0648, 4);  cmp(memb[ds, eax + 96], 0);           /* cmp byte [eax+0x60], 0x0 */
            ii(0x100f_064c, 2);  if(jnz(0x100f_065d, 0xf)) goto l_0x100f_065d;/* jnz 0x100f065d */
            ii(0x100f_064e, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_0651, 5);  call(Definitions.sys_free, 0x7_aa6b); /* call 0x1016b0c1 */
            ii(0x100f_0656, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
        l_0x100f_065d:
            ii(0x100f_065d, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100f_0660, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
        l_0x100f_0663:
            ii(0x100f_0663, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100f_0666, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_0668, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_0669, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_066a, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_066b, 3);  ret(0xc);                             /* ret 0xc */
        }
    }
}
