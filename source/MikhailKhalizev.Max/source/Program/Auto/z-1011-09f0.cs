using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_09f0-6ec2f378")]
        public void Method_1011_09f0()
        {
            ii(0x1011_09f0, 5);  push(0xb4);                           /* push 0xb4 */
            ii(0x1011_09f5, 5);  call(Definitions.sys_check_available_stack_size, 0x5_5358);/* call 0x10165d52 */
            ii(0x1011_09fa, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_09fb, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_09fc, 1);  push(edx);                            /* push edx */
            ii(0x1011_09fd, 1);  push(esi);                            /* push esi */
            ii(0x1011_09fe, 1);  push(edi);                            /* push edi */
            ii(0x1011_09ff, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_0a00, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_0a02, 6);  sub(esp, 0x84);                       /* sub esp, 0x84 */
            ii(0x1011_0a08, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_0a0b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0a0e, 7);  cmp(memd[ds, eax + 324], 0);          /* cmp dword [eax+0x144], 0x0 */
            ii(0x1011_0a15, 2);  if(jz(0x1011_0a48, 0x31)) goto l_0x1011_0a48;/* jz 0x10110a48 */
            ii(0x1011_0a17, 5);  mov(edx, 0x101b_5c10);                /* mov edx, 0x101b5c10 */
            ii(0x1011_0a1c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0a1f, 6);  mov(eax, memd[ds, eax + 324]);        /* mov eax, [eax+0x144] */
            ii(0x1011_0a25, 5);  call(Definitions.sys_call_dtor_arr, 0x5_558e);/* call 0x10165fb8 */
            ii(0x1011_0a2a, 5);  call(Definitions.sys_delete_arr, 0x5_55a9);/* call 0x10165fd8 */
            ii(0x1011_0a2f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0a32, 10);  mov(memd[ds, eax + 324], 0);         /* mov dword [eax+0x144], 0x0 */
            ii(0x1011_0a3c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0a3f, 9);  mov(memw[ds, eax + 330], 0);          /* mov word [eax+0x14a], 0x0 */
        l_0x1011_0a48:
            ii(0x1011_0a48, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0a4b, 6);  mov(al, memb[ds, eax + 321]);         /* mov al, [eax+0x141] */
            ii(0x1011_0a51, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1011_0a56, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_0a58, 6);  if(jz(0x1011_0bb2, 0x154)) goto l_0x1011_0bb2;/* jz 0x10110bb2 */
            ii(0x1011_0a5e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0a61, 7);  cmp(memb[ds, eax + 323], 2);          /* cmp byte [eax+0x143], 0x2 */
            ii(0x1011_0a68, 2);  if(jnz(0x1011_0a90, 0x26)) goto l_0x1011_0a90;/* jnz 0x10110a90 */
            ii(0x1011_0a6a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0a6d, 6);  mov(dl, memb[ds, eax + 322]);         /* mov dl, [eax+0x142] */
            ii(0x1011_0a73, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0a76, 6);  cmp(dl, memb[ds, eax + 321]);         /* cmp dl, [eax+0x141] */
            ii(0x1011_0a7c, 2);  if(jbe(0x1011_0a90, 0x12)) goto l_0x1011_0a90;/* jbe 0x10110a90 */
            ii(0x1011_0a7e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0a81, 6);  mov(dl, memb[ds, eax + 321]);         /* mov dl, [eax+0x141] */
            ii(0x1011_0a87, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0a8a, 6);  mov(memb[ds, eax + 322], dl);         /* mov [eax+0x142], dl */
        l_0x1011_0a90:
            ii(0x1011_0a90, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0a93, 6);  mov(eax, memd[ds, eax + 320]);        /* mov eax, [eax+0x140] */
            ii(0x1011_0a99, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1011_0a9c, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_0a9f, 6);  push(memd[ds, eax + 0x101b_d42c]);    /* push dword [eax+0x101bd42c] */
            ii(0x1011_0aa5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0aa8, 6);  mov(al, memb[ds, eax + 322]);         /* mov al, [eax+0x142] */
            ii(0x1011_0aae, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1011_0ab3, 1);  push(eax);                            /* push eax */
            ii(0x1011_0ab4, 5);  mov(eax, 0x101c_3f00);                /* mov eax, 0x101c3f00 */
            ii(0x1011_0ab9, 1);  push(eax);                            /* push eax */
            ii(0x1011_0aba, 5);  mov(eax, StringDefinitions.SdescrIS); /* mov eax, 0x101a4672 */
            ii(0x1011_0abf, 1);  push(eax);                            /* push eax */
            ii(0x1011_0ac0, 3);  lea(eax, memd[ss, ebp - 128]);        /* lea eax, [ebp-0x80] */
            ii(0x1011_0ac3, 1);  push(eax);                            /* push eax */
            ii(0x1011_0ac4, 5);  call(Definitions.sys_sprintf, 0x5_5438);/* call 0x10165f01 */
            ii(0x1011_0ac9, 3);  add(esp, 0x14);                       /* add esp, 0x14 */
            ii(0x1011_0acc, 5);  mov(edx, StringDefinitions.Rt);       /* mov edx, 0x101a467f */
            ii(0x1011_0ad1, 3);  lea(eax, memd[ss, ebp - 128]);        /* lea eax, [ebp-0x80] */
            ii(0x1011_0ad4, 5);  call(Definitions.my_fopen, -0x2_16ba);/* call 0x100ef41f */
            ii(0x1011_0ad9, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_0adc, 4);  or(memb[ss, ebp - 8], 1);             /* or byte [ebp-0x8], 0x1 */
            ii(0x1011_0ae0, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_0ae3, 5);  call(Definitions.my_string_ctor, 0x3_1000);/* call 0x10141ae8 */
            ii(0x1011_0ae8, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_0aeb, 4);  and(memb[ss, ebp - 8], -2 /* 0xfe */);/* and byte [ebp-0x8], 0xfe */
            ii(0x1011_0aef, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1011_0af3, 2);  if(jz(0x1011_0b26, 0x31)) goto l_0x1011_0b26;/* jz 0x10110b26 */
        l_0x1011_0af5:
            ii(0x1011_0af5, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_0af8, 5);  call(/* sys */ 0x1017_1f05, 0x6_1408);/* call 0x10171f05 */
            ii(0x1011_0afd, 6);  mov(memd[ss, ebp - 132], eax);        /* mov [ebp-0x84], eax */
            ii(0x1011_0b03, 7);  cmp(memd[ss, ebp - 132], -1 /* 0xff */);/* cmp dword [ebp-0x84], 0xffffffff */
            ii(0x1011_0b0a, 2);  if(jz(0x1011_0b1e, 0x12)) goto l_0x1011_0b1e;/* jz 0x10110b1e */
            ii(0x1011_0b0c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_0b0e, 6);  mov(dl, memb[ss, ebp - 132]);         /* mov dl, [ebp-0x84] */
            ii(0x1011_0b14, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_0b17, 5);  call(Definitions.my_string_append_char, 0x3_12ce);/* call 0x10141dea */
            ii(0x1011_0b1c, 2);  jmp(0x1011_0af5, -0x29); goto l_0x1011_0af5;/* jmp 0x10110af5 */
        l_0x1011_0b1e:
            ii(0x1011_0b1e, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_0b21, 5);  call(Definitions.sys_fclose, 0x6_1543);/* call 0x10172069 */
        l_0x1011_0b26:
            ii(0x1011_0b26, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1011_0b2b, 5);  call(/* sys */ 0x1016_a24c, 0x5_971c);/* call 0x1016a24c */
            ii(0x1011_0b30, 7);  mov(dx, memw[ds, 0x101b_ad88]);       /* mov dx, [0x101bad88] */
            ii(0x1011_0b37, 7);  sub(dx, memw[ds, 0x101b_ad80]);       /* sub dx, [0x101bad80] */
            ii(0x1011_0b3e, 3);  mov(memd[ss, ebp - 16], edx);         /* mov [ebp-0x10], edx */
            ii(0x1011_0b41, 7);  mov(dx, memw[ds, 0x101b_ad8c]);       /* mov dx, [0x101bad8c] */
            ii(0x1011_0b48, 7);  sub(dx, memw[ds, 0x101b_ad84]);       /* sub dx, [0x101bad84] */
            ii(0x1011_0b4f, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1011_0b52, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x1011_0b58, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1011_0b5a, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1011_0b5e, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1011_0b60, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1011_0b63, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1011_0b65, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_0b68, 7);  mov(memw[ds, edx + 332], ax);         /* mov [edx+0x14c], ax */
            ii(0x1011_0b6f, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1011_0b73, 2);  if(jz(0x1011_0ba8, 0x33)) goto l_0x1011_0ba8;/* jz 0x10110ba8 */
            ii(0x1011_0b75, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1011_0b78, 6);  add(ecx, 0x148);                      /* add ecx, 0x148 */
            ii(0x1011_0b7e, 4);  movsx(ebx, memw[ss, ebp - 16]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x1011_0b82, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0b85, 8);  imul(ax, memw[ds, eax + 332], 3);     /* imul ax, [eax+0x14c], 0x3 */
            ii(0x1011_0b8d, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_0b90, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_0b93, 5);  call(Definitions.my_strobj_c_str_v2, -0x8_73d0);/* call 0x100897c8 */
            ii(0x1011_0b98, 5);  call(0x100e_969d, -0x2_7500);         /* call 0x100e969d */
            ii(0x1011_0b9d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_0b9f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0ba2, 6);  mov(memd[ds, eax + 324], edx);        /* mov [eax+0x144], edx */
        l_0x1011_0ba8:
            ii(0x1011_0ba8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_0baa, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_0bad, 5);  call(Definitions.my_string_dtor, 0x3_0f78);/* call 0x10141b2a */
        l_0x1011_0bb2:
            ii(0x1011_0bb2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_0bb4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_0bb5, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_0bb6, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_0bb7, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_0bb8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_0bb9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_0bba, 1);  ret();                                /* ret */
        }
    }
}
