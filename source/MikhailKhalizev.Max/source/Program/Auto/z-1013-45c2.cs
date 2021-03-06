using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_45c2-f8399e27")]
        public void Method_1013_45c2()
        {
            ii(0x1013_45c2, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1013_45c7, 5);  call(Definitions.sys_check_available_stack_size, 0x3_1786);/* call 0x10165d52 */
            ii(0x1013_45cc, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_45cd, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_45ce, 1);  push(esi);                            /* push esi */
            ii(0x1013_45cf, 1);  push(edi);                            /* push edi */
            ii(0x1013_45d0, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_45d1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_45d3, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1013_45d9, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_45dc, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1013_45df, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_45e3, 3);  cmp(eax, -1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1013_45e6, 2);  if(jnz(0x1013_45f1, 9)) goto l_0x1013_45f1;/* jnz 0x101345f1 */
            ii(0x1013_45e8, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1013_45ec, 5);  jmp(0x1013_4681, 0x90); goto l_0x1013_4681;/* jmp 0x10134681 */
        l_0x1013_45f1:
            ii(0x1013_45f1, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_45f5, 3);  imul(edx, eax, 7);                    /* imul edx, eax, 0x7 */
            ii(0x1013_45f8, 5);  mov(eax, memd[ds, Definitions.ptr_arr_meta_by_id]);/* mov eax, [0x101c70ec] */
            ii(0x1013_45fd, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1013_45ff, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1013_4602, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_4605, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_4609, 3);  cmp(eax, -1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1013_460c, 2);  if(jnz(0x1013_4614, 6)) goto l_0x1013_4614;/* jnz 0x10134614 */
            ii(0x1013_460e, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1013_4612, 2);  jmp(0x1013_4681, 0x6d); goto l_0x1013_4681;/* jmp 0x10134681 */
        l_0x1013_4614:
            ii(0x1013_4614, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_4618, 3);  imul(edx, eax, 7);                    /* imul edx, eax, 0x7 */
            ii(0x1013_461b, 5);  mov(eax, memd[ds, Definitions.ptr_arr_meta_by_id]);/* mov eax, [0x101c70ec] */
            ii(0x1013_4620, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1013_4622, 3);  mov(al, memb[ds, eax + 6]);           /* mov al, [eax+0x6] */
            ii(0x1013_4625, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1013_4628, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1013_462a, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_462e, 3);  shl(eax, 4);                          /* shl eax, 0x4 */
            ii(0x1013_4631, 6);  mov(edx, memd[ds, Definitions.ptr_arr_meta]);/* mov edx, [0x101c70f0] */
            ii(0x1013_4637, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1013_4639, 3);  mov(edx, memd[ds, edx + 8]);          /* mov edx, [edx+0x8] */
            ii(0x1013_463c, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1013_463e, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1013_4641, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1013_4644, 6);  mov(eax, memd[ds, eax + Definitions.arr_res_file]);/* mov eax, [eax+0x101c70d0] */
            ii(0x1013_464a, 5);  call(Definitions.my_fseek, -0x4_51fa);/* call 0x100ef455 */
            ii(0x1013_464f, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1013_4651, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1013_4654, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1013_4657, 6);  mov(ecx, memd[ds, eax + Definitions.arr_res_file]);/* mov ecx, [eax+0x101c70d0] */
            ii(0x1013_465d, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1013_4662, 5);  mov(edx, 0x309);                      /* mov edx, 0x309 */
            ii(0x1013_4667, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_466a, 5);  call(Definitions.my_fread, -0x4_51e0);/* call 0x100ef48f */
            ii(0x1013_466f, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_4671, 2);  if(jnz(0x1013_467d, 0xa)) goto l_0x1013_467d;/* jnz 0x1013467d */
            ii(0x1013_4673, 5);  mov(eax, 7);                          /* mov eax, 0x7 */
            ii(0x1013_4678, 5);  call(0x100e_f3a0, -0x4_52dd);         /* call 0x100ef3a0 */
        l_0x1013_467d:
            ii(0x1013_467d, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
        l_0x1013_4681:
            ii(0x1013_4681, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1013_4684, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_4686, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_4687, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_4688, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_4689, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_468a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_468b, 1);  ret();                                /* ret */
        }
    }
}
