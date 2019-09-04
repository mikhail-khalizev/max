using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_317c-eea163aa")]
        public void Method_100c_317c()
        {
            ii(0x100c_317c, 5);  push(0x6c);                           /* push 0x6c */
            ii(0x100c_3181, 5);  call(Definitions.sys_check_available_stack_size, 0xa_2bcc);/* call 0x10165d52 */
            ii(0x100c_3186, 1);  push(esi);                            /* push esi */
            ii(0x100c_3187, 1);  push(edi);                            /* push edi */
            ii(0x100c_3188, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_3189, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_318b, 6);  sub(esp, 0x5c);                       /* sub esp, 0x5c */
            ii(0x100c_3191, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_3194, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100c_3197, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100c_319a, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100c_319d, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x100c_31a1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_31a4, 3);  mov(ebx, memd[ds, eax + 6]);          /* mov ebx, [eax+0x6] */
            ii(0x100c_31a7, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100c_31aa, 3);  lea(edx, memd[ss, ebp - 24]);         /* lea edx, [ebp-0x18] */
            ii(0x100c_31ad, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_31b0, 5);  call(0x100c_27f0, -0x9c5);            /* call 0x100c27f0 */
            ii(0x100c_31b5, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_31b8, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100c_31bb, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100c_31c1, 6);  mov(eax, memd[ds, eax + 0x101c_a562]);/* mov eax, [eax+0x101ca562] */
            ii(0x100c_31c7, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_31ca, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_31cd, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x100c_31d0, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100c_31d3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_31d6, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x100c_31d9, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100c_31dc, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_31df, 5);  call(0x1007_6aac, -0x4_c738);         /* call 0x10076aac */
            ii(0x100c_31e4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_31e7, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x100c_31ea, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100c_31ef, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x100c_31f2, 2);  if(jnz(0x100c_3203, 0xf)) goto l_0x100c_3203;/* jnz 0x100c3203 */
            ii(0x100c_31f4, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x100c_31f9, 5);  call(0x1007_5fdc, -0x4_d222);         /* call 0x10075fdc */
            ii(0x100c_31fe, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x100c_3201, 2);  if(jge(0x100c_3205, 2)) goto l_0x100c_3205;/* jge 0x100c3205 */
        l_0x100c_3203:
            ii(0x100c_3203, 2);  jmp(0x100c_322e, 0x29); goto l_0x100c_322e;/* jmp 0x100c322e */
        l_0x100c_3205:
            ii(0x100c_3205, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_3208, 5);  call(0x100c_b39c, 0x818f);            /* call 0x100cb39c */
            ii(0x100c_320d, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_3212, 5);  mov(edx, 0x42);                       /* mov edx, 0x42 */
            ii(0x100c_3217, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x100c_321a, 5);  call(0x100b_8462, -0xadbd);           /* call 0x100b8462 */
            ii(0x100c_321f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_3221, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_3224, 5);  call(0x1008_a41c, -0x3_8e0d);         /* call 0x1008a41c */
            ii(0x100c_3229, 5);  jmp(0x100c_332e, 0x100); goto l_0x100c_332e;/* jmp 0x100c332e */
        l_0x100c_322e:
            ii(0x100c_322e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_3231, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x100c_3234, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100c_3239, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x100c_323c, 2);  if(jnz(0x100c_3266, 0x28)) goto l_0x100c_3266;/* jnz 0x100c3266 */
            ii(0x100c_323e, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x100c_3242, 5);  mov(ebx, 6);                          /* mov ebx, 0x6 */
            ii(0x100c_3247, 3);  lea(edx, memd[ss, ebp - 40]);         /* lea edx, [ebp-0x28] */
            ii(0x100c_324a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_324d, 5);  call(0x100c_27f0, -0xa62);            /* call 0x100c27f0 */
            ii(0x100c_3252, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_3254, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_3257, 5);  call(0x100b_854d, -0xad0f);           /* call 0x100b854d */
            ii(0x100c_325c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_325e, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100c_3261, 5);  call(0x1008_8dcc, -0x3_a49a);         /* call 0x10088dcc */
        l_0x100c_3266:
            ii(0x100c_3266, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_3269, 4);  test(memb[ds, eax + 19], 2);          /* test byte [eax+0x13], 0x2 */
            ii(0x100c_326d, 6);  if(jz(0x100c_332e, 0xbb)) goto l_0x100c_332e;/* jz 0x100c332e */
            ii(0x100c_3273, 4);  mov(memb[ss, ebp - 44], 0);           /* mov byte [ebp-0x2c], 0x0 */
            ii(0x100c_3277, 3);  lea(edx, memd[ss, ebp - 60]);         /* lea edx, [ebp-0x3c] */
            ii(0x100c_327a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_327d, 5);  call(0x1015_2532, 0x8_f2b0);          /* call 0x10152532 */
            ii(0x100c_3282, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x100c_3285, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x100c_3288, 2);  jmp(0x100c_3290, 6); goto l_0x100c_3290;/* jmp 0x100c3290 */
        l_0x100c_328a:
            ii(0x100c_328a, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x100c_328d, 3);  inc(memd[ss, ebp - 64]);              /* inc dword [ebp-0x40] */
        l_0x100c_3290:
            ii(0x100c_3290, 4);  movsx(eax, memw[ss, ebp - 64]);       /* movsx eax, word [ebp-0x40] */
            ii(0x100c_3294, 3);  cmp(eax, memd[ss, ebp - 52]);         /* cmp eax, [ebp-0x34] */
            ii(0x100c_3297, 2);  if(jge(0x100c_32e1, 0x48)) goto l_0x100c_32e1;/* jge 0x100c32e1 */
            ii(0x100c_3299, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x100c_329c, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x100c_329f, 2);  jmp(0x100c_32a7, 6); goto l_0x100c_32a7;/* jmp 0x100c32a7 */
        l_0x100c_32a1:
            ii(0x100c_32a1, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x100c_32a4, 3);  inc(memd[ss, ebp - 68]);              /* inc dword [ebp-0x44] */
        l_0x100c_32a7:
            ii(0x100c_32a7, 4);  movsx(eax, memw[ss, ebp - 68]);       /* movsx eax, word [ebp-0x44] */
            ii(0x100c_32ab, 3);  cmp(eax, memd[ss, ebp - 48]);         /* cmp eax, [ebp-0x30] */
            ii(0x100c_32ae, 2);  if(jge(0x100c_32df, 0x2f)) goto l_0x100c_32df;/* jge 0x100c32df */
            ii(0x100c_32b0, 4);  movsx(edx, memw[ss, ebp - 68]);       /* movsx edx, word [ebp-0x44] */
            ii(0x100c_32b4, 5);  mov(eax, memd[ds, 0x101c_8170]);      /* mov eax, [0x101c8170] */
            ii(0x100c_32b9, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_32bc, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100c_32bf, 4);  movsx(eax, memw[ss, ebp - 64]);       /* movsx eax, word [ebp-0x40] */
            ii(0x100c_32c3, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_32c5, 6);  mov(edx, memd[ds, 0x101c_9454]);      /* mov edx, [0x101c9454] */
            ii(0x100c_32cb, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_32cd, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x100c_32cf, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100c_32d4, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100c_32d7, 2);  if(jnz(0x100c_32dd, 4)) goto l_0x100c_32dd;/* jnz 0x100c32dd */
            ii(0x100c_32d9, 4);  mov(memb[ss, ebp - 44], 1);           /* mov byte [ebp-0x2c], 0x1 */
        l_0x100c_32dd:
            ii(0x100c_32dd, 2);  jmp(0x100c_32a1, -0x3e); goto l_0x100c_32a1;/* jmp 0x100c32a1 */
        l_0x100c_32df:
            ii(0x100c_32df, 2);  jmp(0x100c_328a, -0x57); goto l_0x100c_328a;/* jmp 0x100c328a */
        l_0x100c_32e1:
            ii(0x100c_32e1, 4);  cmp(memb[ss, ebp - 44], 0);           /* cmp byte [ebp-0x2c], 0x0 */
            ii(0x100c_32e5, 2);  if(jz(0x100c_332e, 0x47)) goto l_0x100c_332e;/* jz 0x100c332e */
            ii(0x100c_32e7, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_32ec, 5);  mov(edx, 0x45);                       /* mov edx, 0x45 */
            ii(0x100c_32f1, 3);  lea(eax, memd[ss, ebp - 72]);         /* lea eax, [ebp-0x48] */
            ii(0x100c_32f4, 5);  call(0x100b_8462, -0xae97);           /* call 0x100b8462 */
            ii(0x100c_32f9, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_32fb, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_32fe, 5);  call(0x1008_a41c, -0x3_8ee7);         /* call 0x1008a41c */
            ii(0x100c_3303, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x100c_3308, 5);  call(0x1007_5fdc, -0x4_d331);         /* call 0x10075fdc */
            ii(0x100c_330d, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100c_3310, 2);  if(jl(0x100c_332e, 0x1c)) goto l_0x100c_332e;/* jl 0x100c332e */
            ii(0x100c_3312, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_3317, 5);  mov(edx, 0x47);                       /* mov edx, 0x47 */
            ii(0x100c_331c, 3);  lea(eax, memd[ss, ebp - 76]);         /* lea eax, [ebp-0x4c] */
            ii(0x100c_331f, 5);  call(0x100b_8462, -0xaec2);           /* call 0x100b8462 */
            ii(0x100c_3324, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_3326, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_3329, 5);  call(0x1008_a41c, -0x3_8f12);         /* call 0x1008a41c */
        l_0x100c_332e:
            ii(0x100c_332e, 7);  mov(memd[ss, ebp - 80], 0);           /* mov dword [ebp-0x50], 0x0 */
            ii(0x100c_3335, 2);  jmp(0x100c_333d, 6); goto l_0x100c_333d;/* jmp 0x100c333d */
        l_0x100c_3337:
            ii(0x100c_3337, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x100c_333a, 3);  inc(memd[ss, ebp - 80]);              /* inc dword [ebp-0x50] */
        l_0x100c_333d:
            ii(0x100c_333d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_3340, 5);  call(0x1008_a4a0, -0x3_8ea5);         /* call 0x1008a4a0 */
            ii(0x100c_3345, 4);  cmp(ax, memw[ss, ebp - 80]);          /* cmp ax, [ebp-0x50] */
            ii(0x100c_3349, 6);  if(jle(0x100c_3407, 0xb8)) goto l_0x100c_3407;/* jle 0x100c3407 */
            ii(0x100c_334f, 4);  movsx(edx, memw[ss, ebp - 80]);       /* movsx edx, word [ebp-0x50] */
            ii(0x100c_3353, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_3356, 5);  call(0x1008_a3dc, -0x3_8f7f);         /* call 0x1008a3dc */
            ii(0x100c_335b, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100c_335e, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100c_3361, 6);  mov(al, memb[ds, eax + 0x101c_81d4]); /* mov al, [eax+0x101c81d4] */
            ii(0x100c_3367, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x100c_336a, 4);  movsx(edx, memw[ss, ebp - 80]);       /* movsx edx, word [ebp-0x50] */
            ii(0x100c_336e, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_3371, 5);  call(0x1008_a3dc, -0x3_8f9a);         /* call 0x1008a3dc */
            ii(0x100c_3376, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x100c_3379, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_337c, 5);  call(0x1008_b104, -0x3_827d);         /* call 0x1008b104 */
            ii(0x100c_3381, 4);  mov(ax, memw[ds, eax + 18]);          /* mov ax, [eax+0x12] */
            ii(0x100c_3385, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x100c_3388, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100c_338a, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x100c_338d, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100c_3390, 2);  if(jnz(0x100c_33b1, 0x1f)) goto l_0x100c_33b1;/* jnz 0x100c33b1 */
            ii(0x100c_3392, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_3397, 4);  movsx(ecx, memw[ss, ebp - 84]);       /* movsx ecx, word [ebp-0x54] */
            ii(0x100c_339b, 3);  lea(edx, memd[ss, ebp - 32]);         /* lea edx, [ebp-0x20] */
            ii(0x100c_339e, 3);  lea(eax, memd[ss, ebp - 88]);         /* lea eax, [ebp-0x58] */
            ii(0x100c_33a1, 5);  call(0x1007_5e64, -0x4_d542);         /* call 0x10075e64 */
            ii(0x100c_33a6, 2);  mov(edx, ecx);                        /* mov edx, ecx */
            ii(0x100c_33a8, 5);  call(0x100c_2fc1, -0x3ec);            /* call 0x100c2fc1 */
            ii(0x100c_33ad, 2);  test(al, al);                         /* test al, al */
            ii(0x100c_33af, 2);  if(jz(0x100c_33b3, 2)) goto l_0x100c_33b3;/* jz 0x100c33b3 */
        l_0x100c_33b1:
            ii(0x100c_33b1, 2);  jmp(0x100c_33c5, 0x12); goto l_0x100c_33c5;/* jmp 0x100c33c5 */
        l_0x100c_33b3:
            ii(0x100c_33b3, 4);  movsx(edx, memw[ss, ebp - 80]);       /* movsx edx, word [ebp-0x50] */
            ii(0x100c_33b7, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_33ba, 5);  call(0x1008_a3dc, -0x3_8fe3);         /* call 0x1008a3dc */
            ii(0x100c_33bf, 6);  mov(memw[ds, eax + 2], 0);            /* mov word [eax+0x2], 0x0 */
        l_0x100c_33c5:
            ii(0x100c_33c5, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100c_33c7, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x100c_33ca, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100c_33cd, 2);  if(jnz(0x100c_33ee, 0x1f)) goto l_0x100c_33ee;/* jnz 0x100c33ee */
            ii(0x100c_33cf, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_33d4, 4);  movsx(ecx, memw[ss, ebp - 84]);       /* movsx ecx, word [ebp-0x54] */
            ii(0x100c_33d8, 3);  lea(edx, memd[ss, ebp - 32]);         /* lea edx, [ebp-0x20] */
            ii(0x100c_33db, 3);  lea(eax, memd[ss, ebp - 92]);         /* lea eax, [ebp-0x5c] */
            ii(0x100c_33de, 5);  call(0x1007_5e64, -0x4_d57f);         /* call 0x10075e64 */
            ii(0x100c_33e3, 2);  mov(edx, ecx);                        /* mov edx, ecx */
            ii(0x100c_33e5, 5);  call(0x100c_2fc1, -0x429);            /* call 0x100c2fc1 */
            ii(0x100c_33ea, 2);  test(al, al);                         /* test al, al */
            ii(0x100c_33ec, 2);  if(jz(0x100c_33f0, 2)) goto l_0x100c_33f0;/* jz 0x100c33f0 */
        l_0x100c_33ee:
            ii(0x100c_33ee, 2);  jmp(0x100c_3402, 0x12); goto l_0x100c_3402;/* jmp 0x100c3402 */
        l_0x100c_33f0:
            ii(0x100c_33f0, 4);  movsx(edx, memw[ss, ebp - 80]);       /* movsx edx, word [ebp-0x50] */
            ii(0x100c_33f4, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_33f7, 5);  call(0x1008_a3dc, -0x3_9020);         /* call 0x1008a3dc */
            ii(0x100c_33fc, 6);  mov(memw[ds, eax + 2], 0);            /* mov word [eax+0x2], 0x0 */
        l_0x100c_3402:
            ii(0x100c_3402, 5);  jmp(0x100c_3337, -0xd0); goto l_0x100c_3337;/* jmp 0x100c3337 */
        l_0x100c_3407:
            ii(0x100c_3407, 5);  call(0x1008_a4dc, -0x3_8f30);         /* call 0x1008a4dc */
            ii(0x100c_340c, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100c_340e, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100c_3410, 3);  lea(edx, memd[ss, ebp - 24]);         /* lea edx, [ebp-0x18] */
            ii(0x100c_3413, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_3416, 5);  call(0x100b_8505, -0xaf16);           /* call 0x100b8505 */
            ii(0x100c_341b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_341d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100c_3420, 5);  call(0x1008_8dcc, -0x3_a659);         /* call 0x10088dcc */
            ii(0x100c_3425, 2);  jmp(0x100c_3431, 0xa); goto l_0x100c_3431;/* jmp 0x100c3431 */
        //  ii(0x100c_3427, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x100c_3429, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
        //  ii(0x100c_342c, 5);  call(0x1008_8dcc, -0x3_a665);         /* call 0x10088dcc */
        l_0x100c_3431:
            ii(0x100c_3431, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_3434, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_3436, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_3437, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_3438, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_3439, 1);  ret();                                /* ret */
        }
    }
}
