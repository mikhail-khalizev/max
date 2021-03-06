using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_6536-ed9fa7ce")]
        public void Method_1011_6536()
        {
            ii(0x1011_6536, 5);  push(0x44);                           /* push 0x44 */
            ii(0x1011_653b, 5);  call(Definitions.sys_check_available_stack_size, 0x4_f812);/* call 0x10165d52 */
            ii(0x1011_6540, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_6541, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_6542, 1);  push(esi);                            /* push esi */
            ii(0x1011_6543, 1);  push(edi);                            /* push edi */
            ii(0x1011_6544, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_6545, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_6547, 6);  sub(esp, 0x2c);                       /* sub esp, 0x2c */
            ii(0x1011_654d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_6550, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_6553, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x1011_655a, 2);  if(jz(0x1011_6573, 0x17)) goto l_0x1011_6573;/* jz 0x10116573 */
            ii(0x1011_655c, 5);  mov(edx, 0x101b_671c);                /* mov edx, 0x101b671c */
            ii(0x1011_6561, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_6564, 5);  call(Definitions.sys_call_dtor_arr, 0x4_fa4f);/* call 0x10165fb8 */
            ii(0x1011_6569, 5);  call(Definitions.sys_delete_arr, 0x4_fa6a);/* call 0x10165fd8 */
            ii(0x1011_656e, 5);  jmp(0x1011_6684, 0x111); goto l_0x1011_6684;/* jmp 0x10116684 */
        l_0x1011_6573:
            ii(0x1011_6573, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_6576, 7);  mov(memd[ds, eax + 19], 0x101b_6744); /* mov dword [eax+0x13], 0x101b6744 */
            ii(0x1011_657d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_6580, 3);  mov(eax, memd[ds, eax + 50]);         /* mov eax, [eax+0x32] */
            ii(0x1011_6583, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_6586, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1011_658a, 2);  if(jz(0x1011_65a0, 0x14)) goto l_0x1011_65a0;/* jz 0x101165a0 */
            ii(0x1011_658c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_658e, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_6591, 5);  call(Definitions.my_dtor_d2, -0x4_805e);/* call 0x100ce538 */
            ii(0x1011_6596, 5);  call(Definitions.sys_delete, 0x4_f9c9);/* call 0x10165f64 */
            ii(0x1011_659b, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_659e, 2);  jmp(0x1011_65a7, 7); goto l_0x1011_65a7;/* jmp 0x101165a7 */
        l_0x1011_65a0:
            ii(0x1011_65a0, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1011_65a7:
            ii(0x1011_65a7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_65aa, 4);  cmp(memd[ds, eax + 69], 0);           /* cmp dword [eax+0x45], 0x0 */
            ii(0x1011_65ae, 2);  if(jz(0x1011_65c5, 0x15)) goto l_0x1011_65c5;/* jz 0x101165c5 */
            ii(0x1011_65b0, 5);  mov(edx, 0x101b_5c10);                /* mov edx, 0x101b5c10 */
            ii(0x1011_65b5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_65b8, 3);  mov(eax, memd[ds, eax + 69]);         /* mov eax, [eax+0x45] */
            ii(0x1011_65bb, 5);  call(Definitions.sys_call_dtor_arr, 0x4_f9f8);/* call 0x10165fb8 */
            ii(0x1011_65c0, 5);  call(Definitions.sys_delete_arr, 0x4_fa13);/* call 0x10165fd8 */
        l_0x1011_65c5:
            ii(0x1011_65c5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_65c8, 4);  cmp(memd[ds, eax + 54], 0);           /* cmp dword [eax+0x36], 0x0 */
            ii(0x1011_65cc, 2);  if(jz(0x1011_65f8, 0x2a)) goto l_0x1011_65f8;/* jz 0x101165f8 */
            ii(0x1011_65ce, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_65d1, 3);  mov(eax, memd[ds, eax + 54]);         /* mov eax, [eax+0x36] */
            ii(0x1011_65d4, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_65d7, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1011_65db, 2);  if(jz(0x1011_65f1, 0x14)) goto l_0x1011_65f1;/* jz 0x101165f1 */
            ii(0x1011_65dd, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_65df, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_65e2, 5);  call(Definitions.my_dtor_d2, -0x4_80af);/* call 0x100ce538 */
            ii(0x1011_65e7, 5);  call(Definitions.sys_delete, 0x4_f978);/* call 0x10165f64 */
            ii(0x1011_65ec, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_65ef, 2);  jmp(0x1011_65f8, 7); goto l_0x1011_65f8;/* jmp 0x101165f8 */
        l_0x1011_65f1:
            ii(0x1011_65f1, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x1011_65f8:
            ii(0x1011_65f8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_65fb, 4);  cmp(memd[ds, eax + 58], 0);           /* cmp dword [eax+0x3a], 0x0 */
            ii(0x1011_65ff, 2);  if(jz(0x1011_662b, 0x2a)) goto l_0x1011_662b;/* jz 0x1011662b */
            ii(0x1011_6601, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_6604, 3);  mov(eax, memd[ds, eax + 58]);         /* mov eax, [eax+0x3a] */
            ii(0x1011_6607, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1011_660a, 4);  cmp(memd[ss, ebp - 36], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1011_660e, 2);  if(jz(0x1011_6624, 0x14)) goto l_0x1011_6624;/* jz 0x10116624 */
            ii(0x1011_6610, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_6612, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1011_6615, 5);  call(Definitions.my_dtor_d2, -0x4_80e2);/* call 0x100ce538 */
            ii(0x1011_661a, 5);  call(Definitions.sys_delete, 0x4_f945);/* call 0x10165f64 */
            ii(0x1011_661f, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_6622, 2);  jmp(0x1011_662b, 7); goto l_0x1011_662b;/* jmp 0x1011662b */
        l_0x1011_6624:
            ii(0x1011_6624, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x1011_662b:
            ii(0x1011_662b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_662e, 4);  cmp(memd[ds, eax + 65], 0);           /* cmp dword [eax+0x41], 0x0 */
            ii(0x1011_6632, 2);  if(jz(0x1011_665e, 0x2a)) goto l_0x1011_665e;/* jz 0x1011665e */
            ii(0x1011_6634, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_6637, 3);  mov(eax, memd[ds, eax + 65]);         /* mov eax, [eax+0x41] */
            ii(0x1011_663a, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1011_663d, 4);  cmp(memd[ss, ebp - 44], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1011_6641, 2);  if(jz(0x1011_6657, 0x14)) goto l_0x1011_6657;/* jz 0x10116657 */
            ii(0x1011_6643, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_6645, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1011_6648, 5);  call(Definitions.my_dtor_d3, -0x3_e91a);/* call 0x100d7d33 */
            ii(0x1011_664d, 5);  call(Definitions.sys_delete, 0x4_f912);/* call 0x10165f64 */
            ii(0x1011_6652, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1011_6655, 2);  jmp(0x1011_665e, 7); goto l_0x1011_665e;/* jmp 0x1011665e */
        l_0x1011_6657:
            ii(0x1011_6657, 7);  mov(memd[ss, ebp - 40], 0);           /* mov dword [ebp-0x28], 0x0 */
        l_0x1011_665e:
            ii(0x1011_665e, 5);  call(0x100e_a903, -0x2_bd60);         /* call 0x100ea903 */
            ii(0x1011_6663, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1011_6668, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_666b, 5);  call(0x100d_6999, -0x3_fcd7);         /* call 0x100d6999 */
            ii(0x1011_6670, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_6673, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x1011_667a, 2);  if(jz(0x1011_6684, 8)) goto l_0x1011_6684;/* jz 0x10116684 */
            ii(0x1011_667c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_667f, 5);  call(Definitions.sys_delete, 0x4_f8e0);/* call 0x10165f64 */
        l_0x1011_6684:
            ii(0x1011_6684, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_6687, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_668a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_668d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_668f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_6690, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_6691, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_6692, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_6693, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_6694, 1);  ret();                                /* ret */
        }
    }
}
