using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_3fac-c969f05a")]
        public void Method_1014_3fac()
        {
            ii(0x1014_3fac, 5);  push(0x64);                           /* push 0x64 */
            ii(0x1014_3fb1, 5);  call(Definitions.sys_check_available_stack_size, 0x2_1d9c);/* call 0x10165d52 */
            ii(0x1014_3fb6, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_3fb7, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_3fb8, 1);  push(esi);                            /* push esi */
            ii(0x1014_3fb9, 1);  push(edi);                            /* push edi */
            ii(0x1014_3fba, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_3fbb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_3fbd, 6);  sub(esp, 0x3c);                       /* sub esp, 0x3c */
            ii(0x1014_3fc3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_3fc6, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1014_3fc9, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1014_3fcd, 3);  imul(edx, eax, 0x18);                 /* imul edx, eax, 0x18 */
            ii(0x1014_3fd0, 5);  mov(eax, 0x101b_d70c);                /* mov eax, 0x101bd70c */
            ii(0x1014_3fd5, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1014_3fd7, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_3fda, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1014_3fdf, 5);  call(/* sys */ 0x1016_a24c, 0x2_6268);/* call 0x1016a24c */
            ii(0x1014_3fe4, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_3fe7, 5);  cmp(memw[ds, eax + 8], -1 /* 0xff */);/* cmp word [eax+0x8], 0xffff */
            ii(0x1014_3fec, 6);  if(jnz(0x1014_4069, 0x77)) goto l_0x1014_4069;/* jnz 0x10144069 */
            ii(0x1014_3ff2, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x1014_3ff7, 5);  call(Definitions.sys_new, 0x2_1e04);  /* call 0x10165e00 */
            ii(0x1014_3ffc, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_3fff, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_4002, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_4005, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1014_4009, 2);  if(jz(0x1014_404c, 0x41)) goto l_0x1014_404c;/* jz 0x1014404c */
            ii(0x1014_400b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_400e, 4);  mov(ax, memw[ds, eax + 6]);           /* mov ax, [eax+0x6] */
            ii(0x1014_4012, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1014_4015, 4);  sub(ax, memw[ds, edx + 2]);           /* sub ax, [edx+0x2] */
            ii(0x1014_4019, 1);  cwde();                               /* cwde */
            ii(0x1014_401a, 1);  push(eax);                            /* push eax */
            ii(0x1014_401b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_401e, 4);  mov(ax, memw[ds, eax + 4]);           /* mov ax, [eax+0x4] */
            ii(0x1014_4022, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1014_4025, 3);  sub(ax, memw[ds, edx]);               /* sub ax, [edx] */
            ii(0x1014_4028, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1014_402b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_402e, 2);  mov(ebx, memd[ds, eax]);              /* mov ebx, [eax] */
            ii(0x1014_4030, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1014_4033, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_4036, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1014_4039, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_403c, 5);  call(0x100c_e39d, -0x7_5ca4);         /* call 0x100ce39d */
            ii(0x1014_4041, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_4044, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1014_4047, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1014_404a, 2);  jmp(0x1014_4052, 6); goto l_0x1014_4052;/* jmp 0x10144052 */
        l_0x1014_404c:
            ii(0x1014_404c, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_404f, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
        l_0x1014_4052:
            ii(0x1014_4052, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1014_4056, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1014_4059, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_405c, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1014_405e, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1014_4061, 3);  mov(memd[ds, edx + 34], eax);         /* mov [edx+0x22], eax */
            ii(0x1014_4064, 5);  jmp(0x1014_4123, 0xba); goto l_0x1014_4123;/* jmp 0x10144123 */
        l_0x1014_4069:
            ii(0x1014_4069, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x1014_406e, 5);  call(Definitions.sys_new, 0x2_1d8d);  /* call 0x10165e00 */
            ii(0x1014_4073, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1014_4076, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1014_4079, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1014_407c, 4);  cmp(memd[ss, ebp - 36], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1014_4080, 2);  if(jz(0x1014_40b8, 0x36)) goto l_0x1014_40b8;/* jz 0x101440b8 */
            ii(0x1014_4082, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_4085, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1014_4087, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_408a, 1);  push(eax);                            /* push eax */
            ii(0x1014_408b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_408e, 3);  movsx(ecx, memw[ds, eax]);            /* movsx ecx, word [eax] */
            ii(0x1014_4091, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_4094, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1014_4098, 1);  inc(eax);                             /* inc eax */
            ii(0x1014_4099, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1014_409c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_409f, 3);  mov(edx, memd[ds, eax + 6]);          /* mov edx, [eax+0x6] */
            ii(0x1014_40a2, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1014_40a5, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1014_40a8, 5);  call(Definitions.my_ctor_c17, -0x7_5c9e);/* call 0x100ce40f */
            ii(0x1014_40ad, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1014_40b0, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1014_40b3, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1014_40b6, 2);  jmp(0x1014_40be, 6); goto l_0x1014_40be;/* jmp 0x101440be */
        l_0x1014_40b8:
            ii(0x1014_40b8, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1014_40bb, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
        l_0x1014_40be:
            ii(0x1014_40be, 4);  movsx(edx, memb[ss, ebp - 4]);        /* movsx edx, byte [ebp-0x4] */
            ii(0x1014_40c2, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1014_40c5, 3);  add(edx, memd[ss, ebp - 8]);          /* add edx, [ebp-0x8] */
            ii(0x1014_40c8, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1014_40cb, 3);  mov(memd[ds, edx + 34], eax);         /* mov [edx+0x22], eax */
            ii(0x1014_40ce, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_40d1, 4);  cmp(memd[ds, eax + 10], 0);           /* cmp dword [eax+0xa], 0x0 */
            ii(0x1014_40d5, 2);  if(jz(0x1014_4123, 0x4c)) goto l_0x1014_4123;/* jz 0x10144123 */
            ii(0x1014_40d7, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1014_40da, 5);  call(0x100d_5224, -0x6_eebb);         /* call 0x100d5224 */
            ii(0x1014_40df, 1);  push(eax);                            /* push eax */
            ii(0x1014_40e0, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1014_40e3, 5);  call(0x100d_5250, -0x6_ee98);         /* call 0x100d5250 */
            ii(0x1014_40e8, 1);  push(eax);                            /* push eax */
            ii(0x1014_40e9, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1014_40ec, 5);  call(0x100d_527c, -0x6_ee75);         /* call 0x100d527c */
            ii(0x1014_40f1, 1);  push(eax);                            /* push eax */
            ii(0x1014_40f2, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x1014_40f5, 5);  call(0x100d_52a8, -0x6_ee52);         /* call 0x100d52a8 */
            ii(0x1014_40fa, 1);  push(eax);                            /* push eax */
            ii(0x1014_40fb, 5);  call(0x100d_52d4, -0x6_ee2c);         /* call 0x100d52d4 */
            ii(0x1014_4100, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1014_4103, 5);  call(0x100d_52f8, -0x6_ee10);         /* call 0x100d52f8 */
            ii(0x1014_4108, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1014_410b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_410e, 3);  mov(edx, memd[ds, eax + 10]);         /* mov edx, [eax+0xa] */
            ii(0x1014_4111, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1014_4115, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1014_4118, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1014_411b, 3);  mov(eax, memd[ds, eax + 34]);         /* mov eax, [eax+0x22] */
            ii(0x1014_411e, 5);  call(0x100c_ef64, -0x7_51bf);         /* call 0x100cef64 */
        l_0x1014_4123:
            ii(0x1014_4123, 4);  cmp(memb[ss, ebp - 4], 8);            /* cmp byte [ebp-0x4], 0x8 */
            ii(0x1014_4127, 2);  if(jg(0x1014_4143, 0x1a)) goto l_0x1014_4143;/* jg 0x10144143 */
            ii(0x1014_4129, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_412c, 3);  mov(edx, memd[ds, eax + 14]);         /* mov edx, [eax+0xe] */
            ii(0x1014_412f, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1014_4133, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1014_4136, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1014_4139, 3);  mov(eax, memd[ds, eax + 34]);         /* mov eax, [eax+0x22] */
            ii(0x1014_413c, 5);  call(0x100d_5164, -0x6_efdd);         /* call 0x100d5164 */
            ii(0x1014_4141, 2);  jmp(0x1014_4177, 0x34); goto l_0x1014_4177;/* jmp 0x10144177 */
        l_0x1014_4143:
            ii(0x1014_4143, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_4146, 3);  mov(edx, memd[ds, eax + 14]);         /* mov edx, [eax+0xe] */
            ii(0x1014_4149, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1014_414d, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1014_4150, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1014_4153, 3);  mov(eax, memd[ds, eax + 34]);         /* mov eax, [eax+0x22] */
            ii(0x1014_4156, 5);  call(0x100d_5134, -0x6_f027);         /* call 0x100d5134 */
            ii(0x1014_415b, 4);  movsx(edx, memb[ss, ebp - 4]);        /* movsx edx, byte [ebp-0x4] */
            ii(0x1014_415f, 6);  add(edx, 0x7000);                     /* add edx, 0x7000 */
            ii(0x1014_4165, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1014_4169, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1014_416c, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1014_416f, 3);  mov(eax, memd[ds, eax + 34]);         /* mov eax, [eax+0x22] */
            ii(0x1014_4172, 5);  call(0x100d_5164, -0x6_f013);         /* call 0x100d5164 */
        l_0x1014_4177:
            ii(0x1014_4177, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_4179, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1014_417d, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1014_4180, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1014_4183, 3);  mov(eax, memd[ds, eax + 34]);         /* mov eax, [eax+0x22] */
            ii(0x1014_4186, 5);  call(0x100d_5194, -0x6_eff7);         /* call 0x100d5194 */
            ii(0x1014_418b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_418e, 3);  mov(edx, memd[ds, eax + 20]);         /* mov edx, [eax+0x14] */
            ii(0x1014_4191, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1014_4194, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1014_4198, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1014_419b, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1014_419e, 3);  mov(eax, memd[ds, eax + 34]);         /* mov eax, [eax+0x22] */
            ii(0x1014_41a1, 5);  call(0x100d_50d4, -0x6_f0d2);         /* call 0x100d50d4 */
            ii(0x1014_41a6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_41a9, 3);  mov(edx, memd[ds, eax + 18]);         /* mov edx, [eax+0x12] */
            ii(0x1014_41ac, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1014_41b0, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1014_41b3, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1014_41b6, 3);  mov(eax, memd[ds, eax + 34]);         /* mov eax, [eax+0x22] */
            ii(0x1014_41b9, 5);  call(0x100c_f85c, -0x7_4962);         /* call 0x100cf85c */
            ii(0x1014_41be, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_41c0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_41c1, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_41c2, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_41c3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_41c4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_41c5, 1);  ret();                                /* ret */
        }
    }
}
