using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_9a4a-e81a7ad0")]
        public void Method_100d_9a4a()
        {
            ii(0x100d_9a4a, 5);  push(0xb4);                           /* push 0xb4 */
            ii(0x100d_9a4f, 5);  call(Definitions.sys_check_available_stack_size, 0x8_c2fe);/* call 0x10165d52 */
            ii(0x100d_9a54, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_9a55, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_9a56, 1);  push(esi);                            /* push esi */
            ii(0x100d_9a57, 1);  push(edi);                            /* push edi */
            ii(0x100d_9a58, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_9a59, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_9a5b, 6);  sub(esp, 0x9c);                       /* sub esp, 0x9c */
            ii(0x100d_9a61, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_9a64, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_9a67, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x100d_9a6e, 2);  if(jz(0x100d_9a87, 0x17)) goto l_0x100d_9a87;/* jz 0x100d9a87 */
            ii(0x100d_9a70, 5);  mov(edx, 0x101b_5e8c);                /* mov edx, 0x101b5e8c */
            ii(0x100d_9a75, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9a78, 5);  call(Definitions.sys_call_dtor_arr, 0x8_c53b);/* call 0x10165fb8 */
            ii(0x100d_9a7d, 5);  call(Definitions.sys_delete_arr, 0x8_c556);/* call 0x10165fd8 */
            ii(0x100d_9a82, 5);  jmp(0x100d_9e2e, 0x3a7); goto l_0x100d_9e2e;/* jmp 0x100d9e2e */
        l_0x100d_9a87:
            ii(0x100d_9a87, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9a8a, 7);  mov(memd[ds, eax + 19], 0x101b_5f50); /* mov dword [eax+0x13], 0x101b5f50 */
            ii(0x100d_9a91, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_9a98, 2);  jmp(0x100d_9aa0, 6); goto l_0x100d_9aa0;/* jmp 0x100d9aa0 */
        l_0x100d_9a9a:
            ii(0x100d_9a9a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_9a9d, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x100d_9aa0:
            ii(0x100d_9aa0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_9aa3, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_9aa6, 4);  cmp(ax, memw[ds, edx + 81]);          /* cmp ax, [edx+0x51] */
            ii(0x100d_9aaa, 2);  if(jge(0x100d_9ae2, 0x36)) goto l_0x100d_9ae2;/* jge 0x100d9ae2 */
            ii(0x100d_9aac, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_9ab0, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100d_9ab3, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x100d_9ab6, 6);  mov(eax, memd[ds, eax + 885]);        /* mov eax, [eax+0x375] */
            ii(0x100d_9abc, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x100d_9abf, 4);  cmp(memd[ss, ebp - 88], 0);           /* cmp dword [ebp-0x58], 0x0 */
            ii(0x100d_9ac3, 2);  if(jz(0x100d_9ad9, 0x14)) goto l_0x100d_9ad9;/* jz 0x100d9ad9 */
            ii(0x100d_9ac5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9ac7, 3);  mov(eax, memd[ss, ebp - 88]);         /* mov eax, [ebp-0x58] */
            ii(0x100d_9aca, 5);  call(Definitions.my_dtor_d4, -0x1662);/* call 0x100d846d */
            ii(0x100d_9acf, 5);  call(Definitions.sys_delete, 0x8_c490);/* call 0x10165f64 */
            ii(0x100d_9ad4, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100d_9ad7, 2);  jmp(0x100d_9ae0, 7); goto l_0x100d_9ae0;/* jmp 0x100d9ae0 */
        l_0x100d_9ad9:
            ii(0x100d_9ad9, 7);  mov(memd[ss, ebp - 92], 0);           /* mov dword [ebp-0x5c], 0x0 */
        l_0x100d_9ae0:
            ii(0x100d_9ae0, 2);  jmp(0x100d_9a9a, -0x48); goto l_0x100d_9a9a;/* jmp 0x100d9a9a */
        l_0x100d_9ae2:
            ii(0x100d_9ae2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9ae5, 6);  mov(eax, memd[ds, eax + 837]);        /* mov eax, [eax+0x345] */
            ii(0x100d_9aeb, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100d_9aee, 4);  cmp(memd[ss, ebp - 76], 0);           /* cmp dword [ebp-0x4c], 0x0 */
            ii(0x100d_9af2, 2);  if(jz(0x100d_9b0f, 0x1b)) goto l_0x100d_9b0f;/* jz 0x100d9b0f */
            ii(0x100d_9af4, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_9af7, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x100d_9afa, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_9afd, 3);  mov(ebx, memd[ds, eax + 64]);         /* mov ebx, [eax+0x40] */
            ii(0x100d_9b00, 5);  mov(edx, 2);                          /* mov edx, 0x2 */
            ii(0x100d_9b05, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_9b08, 2);  call_abs(memd[ds, ebx]);              /* call dword [ebx] */
            ii(0x100d_9b0a, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x100d_9b0d, 2);  jmp(0x100d_9b16, 7); goto l_0x100d_9b16;/* jmp 0x100d9b16 */
        l_0x100d_9b0f:
            ii(0x100d_9b0f, 7);  mov(memd[ss, ebp - 96], 0);           /* mov dword [ebp-0x60], 0x0 */
        l_0x100d_9b16:
            ii(0x100d_9b16, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9b19, 6);  mov(eax, memd[ds, eax + 927]);        /* mov eax, [eax+0x39f] */
            ii(0x100d_9b1f, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x100d_9b22, 4);  cmp(memd[ss, ebp - 72], 0);           /* cmp dword [ebp-0x48], 0x0 */
            ii(0x100d_9b26, 2);  if(jz(0x100d_9b3c, 0x14)) goto l_0x100d_9b3c;/* jz 0x100d9b3c */
            ii(0x100d_9b28, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9b2a, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x100d_9b2d, 5);  call(Definitions.my_dtor_d3, -0x1dff);/* call 0x100d7d33 */
            ii(0x100d_9b32, 5);  call(Definitions.sys_delete, 0x8_c42d);/* call 0x10165f64 */
            ii(0x100d_9b37, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
            ii(0x100d_9b3a, 2);  jmp(0x100d_9b43, 7); goto l_0x100d_9b43;/* jmp 0x100d9b43 */
        l_0x100d_9b3c:
            ii(0x100d_9b3c, 7);  mov(memd[ss, ebp - 100], 0);          /* mov dword [ebp-0x64], 0x0 */
        l_0x100d_9b43:
            ii(0x100d_9b43, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9b46, 6);  mov(eax, memd[ds, eax + 931]);        /* mov eax, [eax+0x3a3] */
            ii(0x100d_9b4c, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x100d_9b4f, 4);  cmp(memd[ss, ebp - 68], 0);           /* cmp dword [ebp-0x44], 0x0 */
            ii(0x100d_9b53, 2);  if(jz(0x100d_9b69, 0x14)) goto l_0x100d_9b69;/* jz 0x100d9b69 */
            ii(0x100d_9b55, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9b57, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x100d_9b5a, 5);  call(Definitions.my_dtor_d3, -0x1e2c);/* call 0x100d7d33 */
            ii(0x100d_9b5f, 5);  call(Definitions.sys_delete, 0x8_c400);/* call 0x10165f64 */
            ii(0x100d_9b64, 3);  mov(memd[ss, ebp - 104], eax);        /* mov [ebp-0x68], eax */
            ii(0x100d_9b67, 2);  jmp(0x100d_9b70, 7); goto l_0x100d_9b70;/* jmp 0x100d9b70 */
        l_0x100d_9b69:
            ii(0x100d_9b69, 7);  mov(memd[ss, ebp - 104], 0);          /* mov dword [ebp-0x68], 0x0 */
        l_0x100d_9b70:
            ii(0x100d_9b70, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9b73, 6);  mov(eax, memd[ds, eax + 939]);        /* mov eax, [eax+0x3ab] */
            ii(0x100d_9b79, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x100d_9b7c, 4);  cmp(memd[ss, ebp - 64], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x100d_9b80, 2);  if(jz(0x100d_9b96, 0x14)) goto l_0x100d_9b96;/* jz 0x100d9b96 */
            ii(0x100d_9b82, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9b84, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x100d_9b87, 5);  call(Definitions.my_dtor_d3, -0x1e59);/* call 0x100d7d33 */
            ii(0x100d_9b8c, 5);  call(Definitions.sys_delete, 0x8_c3d3);/* call 0x10165f64 */
            ii(0x100d_9b91, 3);  mov(memd[ss, ebp - 108], eax);        /* mov [ebp-0x6c], eax */
            ii(0x100d_9b94, 2);  jmp(0x100d_9b9d, 7); goto l_0x100d_9b9d;/* jmp 0x100d9b9d */
        l_0x100d_9b96:
            ii(0x100d_9b96, 7);  mov(memd[ss, ebp - 108], 0);          /* mov dword [ebp-0x6c], 0x0 */
        l_0x100d_9b9d:
            ii(0x100d_9b9d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9ba0, 6);  mov(eax, memd[ds, eax + 935]);        /* mov eax, [eax+0x3a7] */
            ii(0x100d_9ba6, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100d_9ba9, 4);  cmp(memd[ss, ebp - 60], 0);           /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x100d_9bad, 2);  if(jz(0x100d_9bc3, 0x14)) goto l_0x100d_9bc3;/* jz 0x100d9bc3 */
            ii(0x100d_9baf, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9bb1, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x100d_9bb4, 5);  call(Definitions.my_dtor_d3, -0x1e86);/* call 0x100d7d33 */
            ii(0x100d_9bb9, 5);  call(Definitions.sys_delete, 0x8_c3a6);/* call 0x10165f64 */
            ii(0x100d_9bbe, 3);  mov(memd[ss, ebp - 112], eax);        /* mov [ebp-0x70], eax */
            ii(0x100d_9bc1, 2);  jmp(0x100d_9bca, 7); goto l_0x100d_9bca;/* jmp 0x100d9bca */
        l_0x100d_9bc3:
            ii(0x100d_9bc3, 7);  mov(memd[ss, ebp - 112], 0);          /* mov dword [ebp-0x70], 0x0 */
        l_0x100d_9bca:
            ii(0x100d_9bca, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9bcd, 6);  mov(eax, memd[ds, eax + 841]);        /* mov eax, [eax+0x349] */
            ii(0x100d_9bd3, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x100d_9bd6, 4);  cmp(memd[ss, ebp - 56], 0);           /* cmp dword [ebp-0x38], 0x0 */
            ii(0x100d_9bda, 2);  if(jz(0x100d_9bf0, 0x14)) goto l_0x100d_9bf0;/* jz 0x100d9bf0 */
            ii(0x100d_9bdc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9bde, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x100d_9be1, 5);  call(Definitions.my_dtor_d2, -0xb6ae);/* call 0x100ce538 */
            ii(0x100d_9be6, 5);  call(Definitions.sys_delete, 0x8_c379);/* call 0x10165f64 */
            ii(0x100d_9beb, 3);  mov(memd[ss, ebp - 116], eax);        /* mov [ebp-0x74], eax */
            ii(0x100d_9bee, 2);  jmp(0x100d_9bf7, 7); goto l_0x100d_9bf7;/* jmp 0x100d9bf7 */
        l_0x100d_9bf0:
            ii(0x100d_9bf0, 7);  mov(memd[ss, ebp - 116], 0);          /* mov dword [ebp-0x74], 0x0 */
        l_0x100d_9bf7:
            ii(0x100d_9bf7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9bfa, 6);  mov(eax, memd[ds, eax + 845]);        /* mov eax, [eax+0x34d] */
            ii(0x100d_9c00, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x100d_9c03, 4);  cmp(memd[ss, ebp - 52], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100d_9c07, 2);  if(jz(0x100d_9c1d, 0x14)) goto l_0x100d_9c1d;/* jz 0x100d9c1d */
            ii(0x100d_9c09, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9c0b, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_9c0e, 5);  call(Definitions.my_dtor_d2, -0xb6db);/* call 0x100ce538 */
            ii(0x100d_9c13, 5);  call(Definitions.sys_delete, 0x8_c34c);/* call 0x10165f64 */
            ii(0x100d_9c18, 3);  mov(memd[ss, ebp - 120], eax);        /* mov [ebp-0x78], eax */
            ii(0x100d_9c1b, 2);  jmp(0x100d_9c24, 7); goto l_0x100d_9c24;/* jmp 0x100d9c24 */
        l_0x100d_9c1d:
            ii(0x100d_9c1d, 7);  mov(memd[ss, ebp - 120], 0);          /* mov dword [ebp-0x78], 0x0 */
        l_0x100d_9c24:
            ii(0x100d_9c24, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9c27, 6);  mov(eax, memd[ds, eax + 849]);        /* mov eax, [eax+0x351] */
            ii(0x100d_9c2d, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x100d_9c30, 4);  cmp(memd[ss, ebp - 84], 0);           /* cmp dword [ebp-0x54], 0x0 */
            ii(0x100d_9c34, 2);  if(jz(0x100d_9c4a, 0x14)) goto l_0x100d_9c4a;/* jz 0x100d9c4a */
            ii(0x100d_9c36, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9c38, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x100d_9c3b, 5);  call(Definitions.my_dtor_d2, -0xb708);/* call 0x100ce538 */
            ii(0x100d_9c40, 5);  call(Definitions.sys_delete, 0x8_c31f);/* call 0x10165f64 */
            ii(0x100d_9c45, 3);  mov(memd[ss, ebp - 124], eax);        /* mov [ebp-0x7c], eax */
            ii(0x100d_9c48, 2);  jmp(0x100d_9c51, 7); goto l_0x100d_9c51;/* jmp 0x100d9c51 */
        l_0x100d_9c4a:
            ii(0x100d_9c4a, 7);  mov(memd[ss, ebp - 124], 0);          /* mov dword [ebp-0x7c], 0x0 */
        l_0x100d_9c51:
            ii(0x100d_9c51, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9c54, 6);  mov(eax, memd[ds, eax + 853]);        /* mov eax, [eax+0x355] */
            ii(0x100d_9c5a, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100d_9c5d, 4);  cmp(memd[ss, ebp - 44], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x100d_9c61, 2);  if(jz(0x100d_9c77, 0x14)) goto l_0x100d_9c77;/* jz 0x100d9c77 */
            ii(0x100d_9c63, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9c65, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x100d_9c68, 5);  call(Definitions.my_dtor_d2, -0xb735);/* call 0x100ce538 */
            ii(0x100d_9c6d, 5);  call(Definitions.sys_delete, 0x8_c2f2);/* call 0x10165f64 */
            ii(0x100d_9c72, 3);  mov(memd[ss, ebp - 128], eax);        /* mov [ebp-0x80], eax */
            ii(0x100d_9c75, 2);  jmp(0x100d_9c7e, 7); goto l_0x100d_9c7e;/* jmp 0x100d9c7e */
        l_0x100d_9c77:
            ii(0x100d_9c77, 7);  mov(memd[ss, ebp - 128], 0);          /* mov dword [ebp-0x80], 0x0 */
        l_0x100d_9c7e:
            ii(0x100d_9c7e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9c81, 6);  mov(eax, memd[ds, eax + 857]);        /* mov eax, [eax+0x359] */
            ii(0x100d_9c87, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100d_9c8a, 4);  cmp(memd[ss, ebp - 40], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100d_9c8e, 2);  if(jz(0x100d_9ca7, 0x17)) goto l_0x100d_9ca7;/* jz 0x100d9ca7 */
            ii(0x100d_9c90, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9c92, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x100d_9c95, 5);  call(Definitions.my_dtor_d2, -0xb762);/* call 0x100ce538 */
            ii(0x100d_9c9a, 5);  call(Definitions.sys_delete, 0x8_c2c5);/* call 0x10165f64 */
            ii(0x100d_9c9f, 6);  mov(memd[ss, ebp - 132], eax);        /* mov [ebp-0x84], eax */
            ii(0x100d_9ca5, 2);  jmp(0x100d_9cb1, 0xa); goto l_0x100d_9cb1;/* jmp 0x100d9cb1 */
        l_0x100d_9ca7:
            ii(0x100d_9ca7, 10);  mov(memd[ss, ebp - 132], 0);         /* mov dword [ebp-0x84], 0x0 */
        l_0x100d_9cb1:
            ii(0x100d_9cb1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9cb4, 6);  mov(eax, memd[ds, eax + 861]);        /* mov eax, [eax+0x35d] */
            ii(0x100d_9cba, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_9cbd, 4);  cmp(memd[ss, ebp - 36], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100d_9cc1, 2);  if(jz(0x100d_9cda, 0x17)) goto l_0x100d_9cda;/* jz 0x100d9cda */
            ii(0x100d_9cc3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9cc5, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100d_9cc8, 5);  call(Definitions.my_dtor_d2, -0xb795);/* call 0x100ce538 */
            ii(0x100d_9ccd, 5);  call(Definitions.sys_delete, 0x8_c292);/* call 0x10165f64 */
            ii(0x100d_9cd2, 6);  mov(memd[ss, ebp - 136], eax);        /* mov [ebp-0x88], eax */
            ii(0x100d_9cd8, 2);  jmp(0x100d_9ce4, 0xa); goto l_0x100d_9ce4;/* jmp 0x100d9ce4 */
        l_0x100d_9cda:
            ii(0x100d_9cda, 10);  mov(memd[ss, ebp - 136], 0);         /* mov dword [ebp-0x88], 0x0 */
        l_0x100d_9ce4:
            ii(0x100d_9ce4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9ce7, 6);  mov(eax, memd[ds, eax + 865]);        /* mov eax, [eax+0x361] */
            ii(0x100d_9ced, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_9cf0, 4);  cmp(memd[ss, ebp - 32], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100d_9cf4, 2);  if(jz(0x100d_9d0d, 0x17)) goto l_0x100d_9d0d;/* jz 0x100d9d0d */
            ii(0x100d_9cf6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9cf8, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_9cfb, 5);  call(Definitions.my_dtor_d2, -0xb7c8);/* call 0x100ce538 */
            ii(0x100d_9d00, 5);  call(Definitions.sys_delete, 0x8_c25f);/* call 0x10165f64 */
            ii(0x100d_9d05, 6);  mov(memd[ss, ebp - 140], eax);        /* mov [ebp-0x8c], eax */
            ii(0x100d_9d0b, 2);  jmp(0x100d_9d17, 0xa); goto l_0x100d_9d17;/* jmp 0x100d9d17 */
        l_0x100d_9d0d:
            ii(0x100d_9d0d, 10);  mov(memd[ss, ebp - 140], 0);         /* mov dword [ebp-0x8c], 0x0 */
        l_0x100d_9d17:
            ii(0x100d_9d17, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9d1a, 6);  mov(eax, memd[ds, eax + 869]);        /* mov eax, [eax+0x365] */
            ii(0x100d_9d20, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100d_9d23, 4);  cmp(memd[ss, ebp - 48], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x100d_9d27, 2);  if(jz(0x100d_9d40, 0x17)) goto l_0x100d_9d40;/* jz 0x100d9d40 */
            ii(0x100d_9d29, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9d2b, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x100d_9d2e, 5);  call(Definitions.my_dtor_d2, -0xb7fb);/* call 0x100ce538 */
            ii(0x100d_9d33, 5);  call(Definitions.sys_delete, 0x8_c22c);/* call 0x10165f64 */
            ii(0x100d_9d38, 6);  mov(memd[ss, ebp - 144], eax);        /* mov [ebp-0x90], eax */
            ii(0x100d_9d3e, 2);  jmp(0x100d_9d4a, 0xa); goto l_0x100d_9d4a;/* jmp 0x100d9d4a */
        l_0x100d_9d40:
            ii(0x100d_9d40, 10);  mov(memd[ss, ebp - 144], 0);         /* mov dword [ebp-0x90], 0x0 */
        l_0x100d_9d4a:
            ii(0x100d_9d4a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9d4d, 6);  mov(eax, memd[ds, eax + 873]);        /* mov eax, [eax+0x369] */
            ii(0x100d_9d53, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_9d56, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100d_9d5a, 2);  if(jz(0x100d_9d73, 0x17)) goto l_0x100d_9d73;/* jz 0x100d9d73 */
            ii(0x100d_9d5c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9d5e, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_9d61, 5);  call(Definitions.my_dtor_d2, -0xb82e);/* call 0x100ce538 */
            ii(0x100d_9d66, 5);  call(Definitions.sys_delete, 0x8_c1f9);/* call 0x10165f64 */
            ii(0x100d_9d6b, 6);  mov(memd[ss, ebp - 148], eax);        /* mov [ebp-0x94], eax */
            ii(0x100d_9d71, 2);  jmp(0x100d_9d7d, 0xa); goto l_0x100d_9d7d;/* jmp 0x100d9d7d */
        l_0x100d_9d73:
            ii(0x100d_9d73, 10);  mov(memd[ss, ebp - 148], 0);         /* mov dword [ebp-0x94], 0x0 */
        l_0x100d_9d7d:
            ii(0x100d_9d7d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9d80, 6);  mov(eax, memd[ds, eax + 877]);        /* mov eax, [eax+0x36d] */
            ii(0x100d_9d86, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_9d89, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100d_9d8d, 2);  if(jz(0x100d_9da6, 0x17)) goto l_0x100d_9da6;/* jz 0x100d9da6 */
            ii(0x100d_9d8f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9d91, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_9d94, 5);  call(Definitions.my_dtor_d2, -0xb861);/* call 0x100ce538 */
            ii(0x100d_9d99, 5);  call(Definitions.sys_delete, 0x8_c1c6);/* call 0x10165f64 */
            ii(0x100d_9d9e, 6);  mov(memd[ss, ebp - 152], eax);        /* mov [ebp-0x98], eax */
            ii(0x100d_9da4, 2);  jmp(0x100d_9db0, 0xa); goto l_0x100d_9db0;/* jmp 0x100d9db0 */
        l_0x100d_9da6:
            ii(0x100d_9da6, 10);  mov(memd[ss, ebp - 152], 0);         /* mov dword [ebp-0x98], 0x0 */
        l_0x100d_9db0:
            ii(0x100d_9db0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9db3, 6);  mov(eax, memd[ds, eax + 881]);        /* mov eax, [eax+0x371] */
            ii(0x100d_9db9, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_9dbc, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100d_9dc0, 2);  if(jz(0x100d_9dd9, 0x17)) goto l_0x100d_9dd9;/* jz 0x100d9dd9 */
            ii(0x100d_9dc2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9dc4, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_9dc7, 5);  call(Definitions.my_dtor_d2, -0xb894);/* call 0x100ce538 */
            ii(0x100d_9dcc, 5);  call(Definitions.sys_delete, 0x8_c193);/* call 0x10165f64 */
            ii(0x100d_9dd1, 6);  mov(memd[ss, ebp - 156], eax);        /* mov [ebp-0x9c], eax */
            ii(0x100d_9dd7, 2);  jmp(0x100d_9de3, 0xa); goto l_0x100d_9de3;/* jmp 0x100d9de3 */
        l_0x100d_9dd9:
            ii(0x100d_9dd9, 10);  mov(memd[ss, ebp - 156], 0);         /* mov dword [ebp-0x9c], 0x0 */
        l_0x100d_9de3:
            ii(0x100d_9de3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9de5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9de8, 5);  add(eax, 0x1cf);                      /* add eax, 0x1cf */
            ii(0x100d_9ded, 5);  call(0x100e_0118, 0x6326);            /* call 0x100e0118 */
            ii(0x100d_9df2, 5);  sub(eax, 0x1cf);                      /* sub eax, 0x1cf */
            ii(0x100d_9df7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_9dfa, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_9dfc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9dff, 3);  add(eax, 0x5b);                       /* add eax, 0x5b */
            ii(0x100d_9e02, 5);  call(0x100e_0118, 0x6311);            /* call 0x100e0118 */
            ii(0x100d_9e07, 3);  sub(eax, 0x5b);                       /* sub eax, 0x5b */
            ii(0x100d_9e0a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_9e0d, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100d_9e12, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9e15, 5);  call(0x100d_6999, -0x3481);           /* call 0x100d6999 */
            ii(0x100d_9e1a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_9e1d, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x100d_9e24, 2);  if(jz(0x100d_9e2e, 8)) goto l_0x100d_9e2e;/* jz 0x100d9e2e */
            ii(0x100d_9e26, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9e29, 5);  call(Definitions.sys_delete, 0x8_c136);/* call 0x10165f64 */
        l_0x100d_9e2e:
            ii(0x100d_9e2e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_9e31, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_9e34, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_9e37, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_9e39, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_9e3a, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_9e3b, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_9e3c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_9e3d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_9e3e, 1);  ret();                                /* ret */
        }
    }
}
