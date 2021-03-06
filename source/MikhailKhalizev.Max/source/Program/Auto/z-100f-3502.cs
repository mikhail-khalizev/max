using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_3502-af92639e")]
        public void Method_100f_3502()
        {
            ii(0x100f_3502, 5);  push(0x38);                           /* push 0x38 */
            ii(0x100f_3507, 5);  call(Definitions.sys_check_available_stack_size, 0x7_2846);/* call 0x10165d52 */
            ii(0x100f_350c, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_350d, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_350e, 1);  push(edx);                            /* push edx */
            ii(0x100f_350f, 1);  push(esi);                            /* push esi */
            ii(0x100f_3510, 1);  push(edi);                            /* push edi */
            ii(0x100f_3511, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_3512, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_3514, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x100f_351a, 5);  mov(eax, 0x37);                       /* mov eax, 0x37 */
            ii(0x100f_351f, 5);  call(0x100e_883d, -0xace7);           /* call 0x100e883d */
            ii(0x100f_3524, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100f_3527, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x100f_352c, 5);  call(0x100e_883d, -0xacf4);           /* call 0x100e883d */
            ii(0x100f_3531, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_3534, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x100f_353b, 2);  jmp(0x100f_3543, 6); goto l_0x100f_3543;/* jmp 0x100f3543 */
        l_0x100f_353d:
            ii(0x100f_353d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_3540, 3);  inc(memd[ss, ebp - 4]);               /* inc dword [ebp-0x4] */
        l_0x100f_3543:
            ii(0x100f_3543, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_3547, 3);  cmp(eax, 5);                          /* cmp eax, 0x5 */
            ii(0x100f_354a, 6);  if(jge(0x100f_35e9, 0x99)) goto l_0x100f_35e9;/* jge 0x100f35e9 */
            ii(0x100f_3550, 5);  call(0x1014_82f4, 0x5_4d9f);          /* call 0x101482f4 */
            ii(0x100f_3555, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100f_3558, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_355b, 5);  add(eax, 0x2fe);                      /* add eax, 0x2fe */
            ii(0x100f_3560, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_3563, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_3566, 5);  add(eax, 0x303);                      /* add eax, 0x303 */
            ii(0x100f_356b, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100f_356e, 5);  call(0x1010_2b60, 0xf5ed);            /* call 0x10102b60 */
            ii(0x100f_3573, 1);  push(eax);                            /* push eax */
            ii(0x100f_3574, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x100f_3579, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100f_357c, 3);  mov(ebx, memd[ds, eax + 4]);          /* mov ebx, [eax+0x4] */
            ii(0x100f_357f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100f_3582, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100f_3584, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_3588, 5);  call(0x100e_8ef1, -0xa69c);           /* call 0x100e8ef1 */
            ii(0x100f_358d, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100f_3590, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100f_3593, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x100f_3596, 5);  call(Definitions.sys_display_draw_1, 0x7_3f0d);/* call 0x101674a8 */
            ii(0x100f_359b, 6);  cmp(memw[ss, ebp - 20], 0x306);       /* cmp word [ebp-0x14], 0x306 */
            ii(0x100f_35a1, 2);  if(jg(0x100f_35d0, 0x2d)) goto l_0x100f_35d0;/* jg 0x100f35d0 */
            ii(0x100f_35a3, 5);  call(0x1010_2b60, 0xf5b8);            /* call 0x10102b60 */
            ii(0x100f_35a8, 1);  push(eax);                            /* push eax */
            ii(0x100f_35a9, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x100f_35ae, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_35b1, 3);  mov(ebx, memd[ds, eax + 4]);          /* mov ebx, [eax+0x4] */
            ii(0x100f_35b4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_35b7, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100f_35b9, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100f_35bd, 5);  call(0x100e_8ef1, -0xa6d1);           /* call 0x100e8ef1 */
            ii(0x100f_35c2, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100f_35c5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_35c8, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x100f_35cb, 5);  call(Definitions.sys_display_draw_1, 0x7_3ed8);/* call 0x101674a8 */
        l_0x100f_35d0:
            ii(0x100f_35d0, 5);  call(/* sys */ 0x1016_b258, 0x7_7c83);/* call 0x1016b258 */
        l_0x100f_35d5:
            ii(0x100f_35d5, 5);  call(0x1014_82f4, 0x5_4d1a);          /* call 0x101482f4 */
            ii(0x100f_35da, 3);  sub(eax, memd[ss, ebp - 24]);         /* sub eax, [ebp-0x18] */
            ii(0x100f_35dd, 5);  cmp(eax, 0xc233);                     /* cmp eax, 0xc233 */
            ii(0x100f_35e2, 2);  if(jb(0x100f_35d5, -0xf)) goto l_0x100f_35d5;/* jb 0x100f35d5 */
            ii(0x100f_35e4, 5);  jmp(0x100f_353d, -0xac); goto l_0x100f_353d;/* jmp 0x100f353d */
        l_0x100f_35e9:
            ii(0x100f_35e9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_35eb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_35ec, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_35ed, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_35ee, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_35ef, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_35f0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_35f1, 1);  ret();                                /* ret */
        }
    }
}
