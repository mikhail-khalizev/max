using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_fbfc-c0cada2c")]
        public void Method_1013_fbfc()
        {
            ii(0x1013_fbfc, 5);  push(0x48);                           /* push 0x48 */
            ii(0x1013_fc01, 5);  call(Definitions.sys_check_available_stack_size, 0x2_614c);/* call 0x10165d52 */
            ii(0x1013_fc06, 1);  push(esi);                            /* push esi */
            ii(0x1013_fc07, 1);  push(edi);                            /* push edi */
            ii(0x1013_fc08, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_fc09, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_fc0b, 6);  sub(esp, 0x2c);                       /* sub esp, 0x2c */
            ii(0x1013_fc11, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_fc14, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1013_fc17, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1013_fc1a, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1013_fc1d, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1013_fc22, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_fc26, 5);  call(0x1007_1e00, -0xc_de2b);         /* call 0x10071e00 */
            ii(0x1013_fc2b, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_fc2e, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_fc32, 5);  call(0x1007_1ec5, -0xc_dd72);         /* call 0x10071ec5 */
            ii(0x1013_fc37, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_fc3a, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_fc3e, 5);  call(0x1007_1f2e, -0xc_dd15);         /* call 0x10071f2e */
            ii(0x1013_fc43, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_fc46, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_fc4a, 5);  call(0x1007_1ff5, -0xc_dc5a);         /* call 0x10071ff5 */
            ii(0x1013_fc4f, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_fc52, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_fc56, 5);  call(0x1007_2073, -0xc_dbe8);         /* call 0x10072073 */
            ii(0x1013_fc5b, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_fc5e, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_fc62, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_fc64, 2);  if(jge(0x1013_fcc3, 0x5d)) goto l_0x1013_fcc3;/* jge 0x1013fcc3 */
            ii(0x1013_fc66, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1013_fc6b, 1);  push(eax);                            /* push eax */
            ii(0x1013_fc6c, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_fc6f, 2);  neg(eax);                             /* neg eax */
            ii(0x1013_fc71, 1);  cwde();                               /* cwde */
            ii(0x1013_fc72, 1);  push(eax);                            /* push eax */
            ii(0x1013_fc73, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1013_fc77, 5);  mov(ebx, StringDefinitions.Prod);     /* mov ebx, 0x101acde2 */
            ii(0x1013_fc7c, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_fc80, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_fc83, 5);  call(0x1013_f4b0, -0x7d8);            /* call 0x1013f4b0 */
            ii(0x1013_fc88, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_fc8b, 2);  neg(eax);                             /* neg eax */
            ii(0x1013_fc8d, 1);  cwde();                               /* cwde */
            ii(0x1013_fc8e, 1);  push(eax);                            /* push eax */
            ii(0x1013_fc8f, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_fc92, 2);  neg(eax);                             /* neg eax */
            ii(0x1013_fc94, 1);  cwde();                               /* cwde */
            ii(0x1013_fc95, 1);  push(eax);                            /* push eax */
            ii(0x1013_fc96, 5);  mov(eax, 0x274);                      /* mov eax, 0x274 */
            ii(0x1013_fc9b, 1);  push(eax);                            /* push eax */
            ii(0x1013_fc9c, 5);  mov(ecx, 0x274);                      /* mov ecx, 0x274 */
            ii(0x1013_fca1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_fca4, 3);  sub(eax, 0x4c);                       /* sub eax, 0x4c */
            ii(0x1013_fca7, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_fcaa, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_fcae, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_fcb1, 3);  add(eax, 0x4c);                       /* add eax, 0x4c */
            ii(0x1013_fcb4, 5);  call(0x1013_f629, -0x690);            /* call 0x1013f629 */
            ii(0x1013_fcb9, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1013_fcbd, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x1013_fcc0, 3);  add(memd[ss, ebp - 16], eax);         /* add [ebp-0x10], eax */
        l_0x1013_fcc3:
            ii(0x1013_fcc3, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1013_fcc7, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_fcc9, 2);  if(jge(0x1013_fd28, 0x5d)) goto l_0x1013_fd28;/* jge 0x1013fd28 */
            ii(0x1013_fccb, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1013_fcd0, 1);  push(eax);                            /* push eax */
            ii(0x1013_fcd1, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_fcd4, 2);  neg(eax);                             /* neg eax */
            ii(0x1013_fcd6, 1);  cwde();                               /* cwde */
            ii(0x1013_fcd7, 1);  push(eax);                            /* push eax */
            ii(0x1013_fcd8, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1013_fcdc, 5);  mov(ebx, StringDefinitions.Prod2);    /* mov ebx, 0x101acde8 */
            ii(0x1013_fce1, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_fce5, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_fce8, 5);  call(0x1013_f4b0, -0x83d);            /* call 0x1013f4b0 */
            ii(0x1013_fced, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_fcf0, 2);  neg(eax);                             /* neg eax */
            ii(0x1013_fcf2, 1);  cwde();                               /* cwde */
            ii(0x1013_fcf3, 1);  push(eax);                            /* push eax */
            ii(0x1013_fcf4, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_fcf7, 2);  neg(eax);                             /* neg eax */
            ii(0x1013_fcf9, 1);  cwde();                               /* cwde */
            ii(0x1013_fcfa, 1);  push(eax);                            /* push eax */
            ii(0x1013_fcfb, 5);  mov(eax, 0x275);                      /* mov eax, 0x275 */
            ii(0x1013_fd00, 1);  push(eax);                            /* push eax */
            ii(0x1013_fd01, 5);  mov(ecx, 0x275);                      /* mov ecx, 0x275 */
            ii(0x1013_fd06, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_fd09, 3);  sub(eax, 0x4c);                       /* sub eax, 0x4c */
            ii(0x1013_fd0c, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_fd0f, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_fd13, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_fd16, 3);  add(eax, 0x4c);                       /* add eax, 0x4c */
            ii(0x1013_fd19, 5);  call(0x1013_f629, -0x6f5);            /* call 0x1013f629 */
            ii(0x1013_fd1e, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1013_fd22, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x1013_fd25, 3);  add(memd[ss, ebp - 16], eax);         /* add [ebp-0x10], eax */
        l_0x1013_fd28:
            ii(0x1013_fd28, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_fd2c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_fd2e, 2);  if(jg(0x1013_fd38, 8)) goto l_0x1013_fd38;/* jg 0x1013fd38 */
            ii(0x1013_fd30, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1013_fd34, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_fd36, 2);  if(jle(0x1013_fd3a, 2)) goto l_0x1013_fd3a;/* jle 0x1013fd3a */
        l_0x1013_fd38:
            ii(0x1013_fd38, 2);  jmp(0x1013_fd42, 8); goto l_0x1013_fd42;/* jmp 0x1013fd42 */
        l_0x1013_fd3a:
            ii(0x1013_fd3a, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_fd3e, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_fd40, 2);  if(jle(0x1013_fd44, 2)) goto l_0x1013_fd44;/* jle 0x1013fd44 */
        l_0x1013_fd42:
            ii(0x1013_fd42, 2);  jmp(0x1013_fd50, 0xc); goto l_0x1013_fd50;/* jmp 0x1013fd50 */
        l_0x1013_fd44:
            ii(0x1013_fd44, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1013_fd48, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_fd4a, 6);  if(jle(0x1013_fe9c, 0x14c)) goto l_0x1013_fe9c;/* jle 0x1013fe9c */
        l_0x1013_fd50:
            ii(0x1013_fd50, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1013_fd55, 1);  push(eax);                            /* push eax */
            ii(0x1013_fd56, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1013_fd58, 1);  push(eax);                            /* push eax */
            ii(0x1013_fd59, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1013_fd5d, 5);  mov(ebx, StringDefinitions.Uses);     /* mov ebx, 0x101acdee */
            ii(0x1013_fd62, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_fd66, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_fd69, 5);  call(0x1013_f4b0, -0x8be);            /* call 0x1013f4b0 */
            ii(0x1013_fd6e, 7);  mov(memd[ss, ebp - 40], 0x4c);        /* mov dword [ebp-0x28], 0x4c */
            ii(0x1013_fd75, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_fd79, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_fd7b, 2);  if(jle(0x1013_fdae, 0x31)) goto l_0x1013_fdae;/* jle 0x1013fdae */
            ii(0x1013_fd7d, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_fd81, 1);  push(eax);                            /* push eax */
            ii(0x1013_fd82, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_fd86, 1);  push(eax);                            /* push eax */
            ii(0x1013_fd87, 5);  mov(eax, 0x270);                      /* mov eax, 0x270 */
            ii(0x1013_fd8c, 1);  push(eax);                            /* push eax */
            ii(0x1013_fd8d, 5);  mov(ecx, 0x270);                      /* mov ecx, 0x270 */
            ii(0x1013_fd92, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_fd95, 3);  sub(eax, memd[ss, ebp - 40]);         /* sub eax, [ebp-0x28] */
            ii(0x1013_fd98, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_fd9b, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_fd9f, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1013_fda3, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1013_fda6, 5);  call(0x1013_f629, -0x782);            /* call 0x1013f629 */
            ii(0x1013_fdab, 3);  add(memd[ss, ebp - 40], eax);         /* add [ebp-0x28], eax */
        l_0x1013_fdae:
            ii(0x1013_fdae, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1013_fdb2, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_fdb4, 2);  if(jle(0x1013_fde7, 0x31)) goto l_0x1013_fde7;/* jle 0x1013fde7 */
            ii(0x1013_fdb6, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1013_fdba, 1);  push(eax);                            /* push eax */
            ii(0x1013_fdbb, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1013_fdbf, 1);  push(eax);                            /* push eax */
            ii(0x1013_fdc0, 5);  mov(eax, 0x26f);                      /* mov eax, 0x26f */
            ii(0x1013_fdc5, 1);  push(eax);                            /* push eax */
            ii(0x1013_fdc6, 5);  mov(ecx, 0x26f);                      /* mov ecx, 0x26f */
            ii(0x1013_fdcb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_fdce, 3);  sub(eax, memd[ss, ebp - 40]);         /* sub eax, [ebp-0x28] */
            ii(0x1013_fdd1, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_fdd4, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_fdd8, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1013_fddc, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1013_fddf, 5);  call(0x1013_f629, -0x7bb);            /* call 0x1013f629 */
            ii(0x1013_fde4, 3);  add(memd[ss, ebp - 40], eax);         /* add [ebp-0x28], eax */
        l_0x1013_fde7:
            ii(0x1013_fde7, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_fdeb, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_fded, 2);  if(jle(0x1013_fe20, 0x31)) goto l_0x1013_fe20;/* jle 0x1013fe20 */
            ii(0x1013_fdef, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_fdf3, 1);  push(eax);                            /* push eax */
            ii(0x1013_fdf4, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_fdf8, 1);  push(eax);                            /* push eax */
            ii(0x1013_fdf9, 5);  mov(eax, 0x274);                      /* mov eax, 0x274 */
            ii(0x1013_fdfe, 1);  push(eax);                            /* push eax */
            ii(0x1013_fdff, 5);  mov(ecx, 0x274);                      /* mov ecx, 0x274 */
            ii(0x1013_fe04, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_fe07, 3);  sub(eax, memd[ss, ebp - 40]);         /* sub eax, [ebp-0x28] */
            ii(0x1013_fe0a, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_fe0d, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_fe11, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1013_fe15, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1013_fe18, 5);  call(0x1013_f629, -0x7f4);            /* call 0x1013f629 */
            ii(0x1013_fe1d, 3);  add(memd[ss, ebp - 40], eax);         /* add [ebp-0x28], eax */
        l_0x1013_fe20:
            ii(0x1013_fe20, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1013_fe24, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_fe26, 2);  if(jle(0x1013_fe59, 0x31)) goto l_0x1013_fe59;/* jle 0x1013fe59 */
            ii(0x1013_fe28, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1013_fe2c, 1);  push(eax);                            /* push eax */
            ii(0x1013_fe2d, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1013_fe31, 1);  push(eax);                            /* push eax */
            ii(0x1013_fe32, 5);  mov(eax, 0x275);                      /* mov eax, 0x275 */
            ii(0x1013_fe37, 1);  push(eax);                            /* push eax */
            ii(0x1013_fe38, 5);  mov(ecx, 0x275);                      /* mov ecx, 0x275 */
            ii(0x1013_fe3d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_fe40, 3);  sub(eax, memd[ss, ebp - 40]);         /* sub eax, [ebp-0x28] */
            ii(0x1013_fe43, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_fe46, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_fe4a, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1013_fe4e, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1013_fe51, 5);  call(0x1013_f629, -0x82d);            /* call 0x1013f629 */
            ii(0x1013_fe56, 3);  add(memd[ss, ebp - 40], eax);         /* add [ebp-0x28], eax */
        l_0x1013_fe59:
            ii(0x1013_fe59, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1013_fe5d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_fe5f, 2);  if(jle(0x1013_fe92, 0x31)) goto l_0x1013_fe92;/* jle 0x1013fe92 */
            ii(0x1013_fe61, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1013_fe65, 1);  push(eax);                            /* push eax */
            ii(0x1013_fe66, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1013_fe6a, 1);  push(eax);                            /* push eax */
            ii(0x1013_fe6b, 5);  mov(eax, 0x272);                      /* mov eax, 0x272 */
            ii(0x1013_fe70, 1);  push(eax);                            /* push eax */
            ii(0x1013_fe71, 5);  mov(ecx, 0x272);                      /* mov ecx, 0x272 */
            ii(0x1013_fe76, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_fe79, 3);  sub(eax, memd[ss, ebp - 40]);         /* sub eax, [ebp-0x28] */
            ii(0x1013_fe7c, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1013_fe7f, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1013_fe83, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1013_fe87, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1013_fe8a, 5);  call(0x1013_f629, -0x866);            /* call 0x1013f629 */
            ii(0x1013_fe8f, 3);  add(memd[ss, ebp - 40], eax);         /* add [ebp-0x28], eax */
        l_0x1013_fe92:
            ii(0x1013_fe92, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1013_fe96, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x1013_fe99, 3);  add(memd[ss, ebp - 16], eax);         /* add [ebp-0x10], eax */
        l_0x1013_fe9c:
            ii(0x1013_fe9c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_fe9f, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1013_fea2, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1013_fea5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_fea7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_fea8, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_fea9, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_feaa, 1);  ret();                                /* ret */
        }
    }
}
