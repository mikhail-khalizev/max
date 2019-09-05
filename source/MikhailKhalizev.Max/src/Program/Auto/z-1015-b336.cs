using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b336-4e61d6")]
        public void Method_1015_b336()
        {
            ii(0x1015_b336, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1015_b33b, 5);  call(Definitions.sys_check_available_stack_size, 0xaa12);/* call 0x10165d52 */
            ii(0x1015_b340, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_b341, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_b342, 1);  push(edx);                            /* push edx */
            ii(0x1015_b343, 1);  push(esi);                            /* push esi */
            ii(0x1015_b344, 1);  push(edi);                            /* push edi */
            ii(0x1015_b345, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_b346, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_b348, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1015_b34e, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_b351, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b354, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1015_b358, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_b35b, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1015_b35f, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x1015_b362, 5);  mov(edx, 0x101c_81c0);                /* mov edx, 0x101c81c0 */
            ii(0x1015_b367, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1015_b369, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1015_b36c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_b36f, 4);  cmp(memd[ds, eax + 39], 0);           /* cmp dword [eax+0x27], 0x0 */
            ii(0x1015_b373, 6);  if(jnz(0x1015_b44b, 0xd2)) goto l_0x1015_b44b;/* jnz 0x1015b44b */
            ii(0x1015_b379, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1015_b37d, 3);  imul(eax, eax, 0x2b);                 /* imul eax, eax, 0x2b */
            ii(0x1015_b380, 6);  mov(eax, memd[ds, eax + 0x101c_94ed]);/* mov eax, [eax+0x101c94ed] */
            ii(0x1015_b386, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_b389, 5);  call(Definitions.my_get_res_data_by_id, -0x2_73b6);/* call 0x10133fd8 */
            ii(0x1015_b38e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_b390, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_b393, 3);  mov(memd[ds, eax + 39], edx);         /* mov [eax+0x27], edx */
            ii(0x1015_b396, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1015_b39a, 3);  imul(eax, eax, 0x2b);                 /* imul eax, eax, 0x2b */
            ii(0x1015_b39d, 6);  mov(eax, memd[ds, eax + 0x101c_94ef]);/* mov eax, [eax+0x101c94ef] */
            ii(0x1015_b3a3, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_b3a6, 5);  call(Definitions.my_get_res_data_by_id, -0x2_73d3);/* call 0x10133fd8 */
            ii(0x1015_b3ab, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_b3ad, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_b3b0, 3);  mov(memd[ds, eax + 43], edx);         /* mov [eax+0x2b], edx */
            ii(0x1015_b3b3, 7);  cmp(memb[ds, 0x101c_814a], 0);        /* cmp byte [0x101c814a], 0x0 */
            ii(0x1015_b3ba, 6);  if(jz(0x1015_b44b, 0x8b)) goto l_0x1015_b44b;/* jz 0x1015b44b */
            ii(0x1015_b3c0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_b3c3, 4);  cmp(memd[ds, eax + 39], 0);           /* cmp dword [eax+0x27], 0x0 */
            ii(0x1015_b3c7, 2);  if(jz(0x1015_b404, 0x3b)) goto l_0x1015_b404;/* jz 0x1015b404 */
            ii(0x1015_b3c9, 5);  mov(ecx, 2);                          /* mov ecx, 0x2 */
            ii(0x1015_b3ce, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1015_b3d0, 3);  lea(edx, memd[ss, ebp - 16]);         /* lea edx, [ebp-0x10] */
            ii(0x1015_b3d3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_b3d6, 3);  mov(eax, memd[ds, eax + 39]);         /* mov eax, [eax+0x27] */
            ii(0x1015_b3d9, 5);  call(0x1015_aefb, -0x4e3);            /* call 0x1015aefb */
            ii(0x1015_b3de, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_b3e0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_b3e3, 3);  mov(memd[ds, eax + 39], edx);         /* mov [eax+0x27], edx */
            ii(0x1015_b3e6, 3);  mov(ebx, memd[ss, ebp - 16]);         /* mov ebx, [ebp-0x10] */
            ii(0x1015_b3e9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_b3ec, 3);  mov(edx, memd[ds, eax + 39]);         /* mov edx, [eax+0x27] */
            ii(0x1015_b3ef, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1015_b3f3, 3);  imul(eax, eax, 0x2b);                 /* imul eax, eax, 0x2b */
            ii(0x1015_b3f6, 6);  mov(eax, memd[ds, eax + 0x101c_94ed]);/* mov eax, [eax+0x101c94ed] */
            ii(0x1015_b3fc, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_b3ff, 5);  call(0x1013_4157, -0x2_72ad);         /* call 0x10134157 */
        l_0x1015_b404:
            ii(0x1015_b404, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_b407, 4);  cmp(memd[ds, eax + 43], 0);           /* cmp dword [eax+0x2b], 0x0 */
            ii(0x1015_b40b, 2);  if(jz(0x1015_b44b, 0x3e)) goto l_0x1015_b44b;/* jz 0x1015b44b */
            ii(0x1015_b40d, 5);  mov(ecx, 2);                          /* mov ecx, 0x2 */
            ii(0x1015_b412, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1015_b417, 3);  lea(edx, memd[ss, ebp - 16]);         /* lea edx, [ebp-0x10] */
            ii(0x1015_b41a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_b41d, 3);  mov(eax, memd[ds, eax + 43]);         /* mov eax, [eax+0x2b] */
            ii(0x1015_b420, 5);  call(0x1015_aefb, -0x52a);            /* call 0x1015aefb */
            ii(0x1015_b425, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_b427, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_b42a, 3);  mov(memd[ds, eax + 43], edx);         /* mov [eax+0x2b], edx */
            ii(0x1015_b42d, 3);  mov(ebx, memd[ss, ebp - 16]);         /* mov ebx, [ebp-0x10] */
            ii(0x1015_b430, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_b433, 3);  mov(edx, memd[ds, eax + 43]);         /* mov edx, [eax+0x2b] */
            ii(0x1015_b436, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1015_b43a, 3);  imul(eax, eax, 0x2b);                 /* imul eax, eax, 0x2b */
            ii(0x1015_b43d, 6);  mov(eax, memd[ds, eax + 0x101c_94ef]);/* mov eax, [eax+0x101c94ef] */
            ii(0x1015_b443, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_b446, 5);  call(0x1013_4157, -0x2_72f4);         /* call 0x10134157 */
        l_0x1015_b44b:
            ii(0x1015_b44b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b44e, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1015_b452, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_b455, 5);  jmp(0x1015_b704, 0x2aa); goto l_0x1015_b704;/* jmp 0x1015b704 */
        l_0x1015_b45a:
            ii(0x1015_b45a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b45d, 7);  mov(memd[ds, eax + 10], 0x101c_b04c); /* mov dword [eax+0xa], 0x101cb04c */
            ii(0x1015_b464, 5);  jmp(0x1015_b725, 0x2bc); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b469:
            ii(0x1015_b469, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b46c, 7);  mov(memd[ds, eax + 10], 0x101c_b044); /* mov dword [eax+0xa], 0x101cb044 */
            ii(0x1015_b473, 5);  jmp(0x1015_b725, 0x2ad); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b478:
            ii(0x1015_b478, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b47b, 7);  mov(memd[ds, eax + 10], 0x101c_b024); /* mov dword [eax+0xa], 0x101cb024 */
            ii(0x1015_b482, 5);  jmp(0x1015_b725, 0x29e); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b487:
            ii(0x1015_b487, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b48a, 7);  mov(memd[ds, eax + 10], 0x101c_b02c); /* mov dword [eax+0xa], 0x101cb02c */
            ii(0x1015_b491, 5);  jmp(0x1015_b725, 0x28f); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b496:
            ii(0x1015_b496, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b499, 7);  mov(memd[ds, eax + 10], 0x101c_b07c); /* mov dword [eax+0xa], 0x101cb07c */
            ii(0x1015_b4a0, 5);  jmp(0x1015_b725, 0x280); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b4a5:
            ii(0x1015_b4a5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b4a8, 7);  mov(memd[ds, eax + 10], 0x101c_b054); /* mov dword [eax+0xa], 0x101cb054 */
            ii(0x1015_b4af, 5);  jmp(0x1015_b725, 0x271); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b4b4:
            ii(0x1015_b4b4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b4b7, 7);  mov(memd[ds, eax + 10], 0x101c_b05c); /* mov dword [eax+0xa], 0x101cb05c */
            ii(0x1015_b4be, 5);  jmp(0x1015_b725, 0x262); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b4c3:
            ii(0x1015_b4c3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b4c6, 7);  mov(memd[ds, eax + 10], 0x101c_b064); /* mov dword [eax+0xa], 0x101cb064 */
            ii(0x1015_b4cd, 5);  jmp(0x1015_b725, 0x253); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b4d2:
            ii(0x1015_b4d2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b4d5, 7);  mov(memd[ds, eax + 10], 0x101c_b014); /* mov dword [eax+0xa], 0x101cb014 */
            ii(0x1015_b4dc, 5);  jmp(0x1015_b725, 0x244); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b4e1:
            ii(0x1015_b4e1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b4e4, 7);  mov(memd[ds, eax + 10], 0x101c_affc); /* mov dword [eax+0xa], 0x101caffc */
            ii(0x1015_b4eb, 5);  jmp(0x1015_b725, 0x235); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b4f0:
            ii(0x1015_b4f0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b4f3, 7);  mov(memd[ds, eax + 10], 0x101c_aff4); /* mov dword [eax+0xa], 0x101caff4 */
            ii(0x1015_b4fa, 5);  jmp(0x1015_b725, 0x226); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b4ff:
            ii(0x1015_b4ff, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b502, 7);  mov(memd[ds, eax + 10], 0x101c_b01c); /* mov dword [eax+0xa], 0x101cb01c */
            ii(0x1015_b509, 5);  jmp(0x1015_b725, 0x217); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b50e:
            ii(0x1015_b50e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b511, 7);  mov(memd[ds, eax + 10], 0x101c_b004); /* mov dword [eax+0xa], 0x101cb004 */
            ii(0x1015_b518, 5);  jmp(0x1015_b725, 0x208); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b51d:
            ii(0x1015_b51d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b520, 7);  mov(memd[ds, eax + 10], 0x101c_b034); /* mov dword [eax+0xa], 0x101cb034 */
            ii(0x1015_b527, 5);  jmp(0x1015_b725, 0x1f9); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b52c:
            ii(0x1015_b52c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b52f, 7);  mov(memd[ds, eax + 10], 0x101c_b03c); /* mov dword [eax+0xa], 0x101cb03c */
            ii(0x1015_b536, 5);  jmp(0x1015_b725, 0x1ea); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b53b:
            ii(0x1015_b53b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b53e, 7);  mov(memd[ds, eax + 10], 0x101c_b06c); /* mov dword [eax+0xa], 0x101cb06c */
            ii(0x1015_b545, 5);  jmp(0x1015_b725, 0x1db); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b54a:
            ii(0x1015_b54a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b54d, 7);  mov(memd[ds, eax + 10], 0x101c_b00c); /* mov dword [eax+0xa], 0x101cb00c */
            ii(0x1015_b554, 5);  jmp(0x1015_b725, 0x1cc); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b559:
            ii(0x1015_b559, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b55c, 7);  mov(memd[ds, eax + 10], 0x101c_b074); /* mov dword [eax+0xa], 0x101cb074 */
            ii(0x1015_b563, 5);  jmp(0x1015_b725, 0x1bd); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b568:
            ii(0x1015_b568, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b56b, 7);  mov(memd[ds, eax + 10], 0x101c_afd4); /* mov dword [eax+0xa], 0x101cafd4 */
            ii(0x1015_b572, 5);  jmp(0x1015_b725, 0x1ae); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b577:
            ii(0x1015_b577, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b57a, 7);  mov(memd[ds, eax + 10], 0x101c_afdc); /* mov dword [eax+0xa], 0x101cafdc */
            ii(0x1015_b581, 5);  jmp(0x1015_b725, 0x19f); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b586:
            ii(0x1015_b586, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b589, 7);  mov(memd[ds, eax + 10], 0x101c_afe4); /* mov dword [eax+0xa], 0x101cafe4 */
            ii(0x1015_b590, 5);  jmp(0x1015_b725, 0x190); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b595:
            ii(0x1015_b595, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b598, 7);  mov(memd[ds, eax + 10], 0x101c_afec); /* mov dword [eax+0xa], 0x101cafec */
            ii(0x1015_b59f, 5);  jmp(0x1015_b725, 0x181); goto l_0x1015_b725;/* jmp 0x1015b725 */
        l_0x1015_b5a4:
            ii(0x1015_b5a4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b5a7, 7);  mov(memd[ds, eax + 10], 0x101c_afcc); /* mov dword [eax+0xa], 0x101cafcc */
            ii(0x1015_b5ae, 5);  jmp(0x1015_b725, 0x172); goto l_0x1015_b725;/* jmp 0x1015b725 */
        //  ii(0x1015_b5b3, 1);  nop();                                /* nop */
        //  ii(0x1015_b5b4, 336);  /* Служебная область с абсолютными адресами переходов. (0x1015_b496, 0x1015_b4c3, 0x1015_b4c3, 0x1015_b487, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b4d2, 0x1015_b4ff, 0x1015_b5a4, 0x1015_b487, 0x1015_b487, 0x1015_b487, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b52c, 0x1015_b52c, 0x1015_b52c, 0x1015_b5a4, 0x1015_b52c, 0x1015_b5a4, 0x1015_b4b4, 0x1015_b4a5, 0x1015_b469, 0x1015_b52c, 0x1015_b5a4, 0x1015_b586, 0x1015_b586, 0x1015_b586, 0x1015_b586, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b45a, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b5a4, 0x1015_b559, 0x1015_b51d, 0x1015_b586, 0x1015_b586, 0x1015_b586, 0x1015_b586, 0x1015_b586, 0x1015_b586, 0x1015_b4e1, 0x1015_b577, 0x1015_b568, 0x1015_b4f0, 0x1015_b568, 0x1015_b51d, 0x1015_b53b, 0x1015_b54a, 0x1015_b50e, 0x1015_b478, 0x1015_b595, 0x1015_b586, 0x1015_b586, 0x1015_b586, 0x1015_b586, 0x1015_b586, 0x1015_b478, 0x1015_b586, 0x1015_b4e1, 0x1015_b4f0, 0x1015_b586, 0x1015_b586, 0x1015_b478, 0x1015_b5a4, 0x1015_b586, 0x1015_b586, 0x1015_b586, 0x1015_b586). */
        l_0x1015_b704:
            ii(0x1015_b704, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_b707, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1015_b70a, 5);  cmp(memw[ss, ebp - 24], 0x53);        /* cmp word [ebp-0x18], 0x53 */
            ii(0x1015_b70f, 6);  if(ja(0x1015_b5a4, -0x171)) goto l_0x1015_b5a4;/* ja 0x1015b5a4 */
            ii(0x1015_b715, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_b717, 4);  mov(ax, memw[ss, ebp - 24]);          /* mov ax, [ebp-0x18] */
            ii(0x1015_b71b, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1015_b71e, 7);  /* jmp dword [cs:eax+0x1015b5b4] */
            switch (jmp_abs_switch(memd[cs, eax + 0x1015_b5b4]))
            {
                case 0x1015_b45a:
                    goto l_0x1015_b45a;
                case 0x1015_b469:
                    goto l_0x1015_b469;
                case 0x1015_b478:
                    goto l_0x1015_b478;
                case 0x1015_b487:
                    goto l_0x1015_b487;
                case 0x1015_b496:
                    goto l_0x1015_b496;
                case 0x1015_b4a5:
                    goto l_0x1015_b4a5;
                case 0x1015_b4b4:
                    goto l_0x1015_b4b4;
                case 0x1015_b4c3:
                    goto l_0x1015_b4c3;
                case 0x1015_b4d2:
                    goto l_0x1015_b4d2;
                case 0x1015_b4e1:
                    goto l_0x1015_b4e1;
                case 0x1015_b4f0:
                    goto l_0x1015_b4f0;
                case 0x1015_b4ff:
                    goto l_0x1015_b4ff;
                case 0x1015_b50e:
                    goto l_0x1015_b50e;
                case 0x1015_b51d:
                    goto l_0x1015_b51d;
                case 0x1015_b52c:
                    goto l_0x1015_b52c;
                case 0x1015_b53b:
                    goto l_0x1015_b53b;
                case 0x1015_b54a:
                    goto l_0x1015_b54a;
                case 0x1015_b559:
                    goto l_0x1015_b559;
                case 0x1015_b568:
                    goto l_0x1015_b568;
                case 0x1015_b577:
                    goto l_0x1015_b577;
                case 0x1015_b586:
                    goto l_0x1015_b586;
                case 0x1015_b595:
                    goto l_0x1015_b595;
                case 0x1015_b5a4:
                    goto l_0x1015_b5a4;
                default:
                    throw new NotImplementedException();
            }
        l_0x1015_b725:
            ii(0x1015_b725, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b728, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1015_b72c, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1015_b72f, 5);  jmp(0x1015_bca0, 0x56c); goto l_0x1015_bca0;/* jmp 0x1015bca0 */
        l_0x1015_b734:
            ii(0x1015_b734, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b737, 7);  mov(memd[ds, eax + 14], 0x101b_d95b); /* mov dword [eax+0xe], 0x101bd95b */
            ii(0x1015_b73e, 5);  jmp(0x1015_bcc1, 0x57e); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b743:
            ii(0x1015_b743, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b746, 7);  mov(memd[ds, eax + 14], 0x101b_d96b); /* mov dword [eax+0xe], 0x101bd96b */
            ii(0x1015_b74d, 5);  jmp(0x1015_bcc1, 0x56f); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b752:
            ii(0x1015_b752, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b755, 7);  mov(memd[ds, eax + 14], 0x101b_d97b); /* mov dword [eax+0xe], 0x101bd97b */
            ii(0x1015_b75c, 5);  jmp(0x1015_bcc1, 0x560); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b761:
            ii(0x1015_b761, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b764, 7);  mov(memd[ds, eax + 14], 0x101b_d98b); /* mov dword [eax+0xe], 0x101bd98b */
            ii(0x1015_b76b, 5);  jmp(0x1015_bcc1, 0x551); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b770:
            ii(0x1015_b770, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b773, 7);  mov(memd[ds, eax + 14], 0x101b_d992); /* mov dword [eax+0xe], 0x101bd992 */
            ii(0x1015_b77a, 5);  jmp(0x1015_bcc1, 0x542); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b77f:
            ii(0x1015_b77f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b782, 7);  mov(memd[ds, eax + 14], 0x101b_d9a2); /* mov dword [eax+0xe], 0x101bd9a2 */
            ii(0x1015_b789, 5);  jmp(0x1015_bcc1, 0x533); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b78e:
            ii(0x1015_b78e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b791, 7);  mov(memd[ds, eax + 14], 0x101b_d9ac); /* mov dword [eax+0xe], 0x101bd9ac */
            ii(0x1015_b798, 5);  jmp(0x1015_bcc1, 0x524); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b79d:
            ii(0x1015_b79d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b7a0, 7);  mov(memd[ds, eax + 14], 0x101b_d9b3); /* mov dword [eax+0xe], 0x101bd9b3 */
            ii(0x1015_b7a7, 5);  jmp(0x1015_bcc1, 0x515); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b7ac:
            ii(0x1015_b7ac, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b7af, 7);  mov(memd[ds, eax + 14], 0x101b_d9ba); /* mov dword [eax+0xe], 0x101bd9ba */
            ii(0x1015_b7b6, 5);  jmp(0x1015_bcc1, 0x506); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b7bb:
            ii(0x1015_b7bb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b7be, 7);  mov(memd[ds, eax + 14], 0x101b_d9c1); /* mov dword [eax+0xe], 0x101bd9c1 */
            ii(0x1015_b7c5, 5);  jmp(0x1015_bcc1, 0x4f7); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b7ca:
            ii(0x1015_b7ca, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b7cd, 7);  mov(memd[ds, eax + 14], 0x101b_d9c8); /* mov dword [eax+0xe], 0x101bd9c8 */
            ii(0x1015_b7d4, 5);  jmp(0x1015_bcc1, 0x4e8); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b7d9:
            ii(0x1015_b7d9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b7dc, 7);  mov(memd[ds, eax + 14], 0x101b_d9cf); /* mov dword [eax+0xe], 0x101bd9cf */
            ii(0x1015_b7e3, 5);  jmp(0x1015_bcc1, 0x4d9); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b7e8:
            ii(0x1015_b7e8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b7eb, 7);  mov(memd[ds, eax + 14], 0x101b_d9d6); /* mov dword [eax+0xe], 0x101bd9d6 */
            ii(0x1015_b7f2, 5);  jmp(0x1015_bcc1, 0x4ca); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b7f7:
            ii(0x1015_b7f7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b7fa, 7);  mov(memd[ds, eax + 14], 0x101b_d9dd); /* mov dword [eax+0xe], 0x101bd9dd */
            ii(0x1015_b801, 5);  jmp(0x1015_bcc1, 0x4bb); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b806:
            ii(0x1015_b806, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b809, 7);  mov(memd[ds, eax + 14], 0x101b_d9e4); /* mov dword [eax+0xe], 0x101bd9e4 */
            ii(0x1015_b810, 5);  jmp(0x1015_bcc1, 0x4ac); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b815:
            ii(0x1015_b815, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b818, 7);  mov(memd[ds, eax + 14], 0x101b_d9f4); /* mov dword [eax+0xe], 0x101bd9f4 */
            ii(0x1015_b81f, 5);  jmp(0x1015_bcc1, 0x49d); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b824:
            ii(0x1015_b824, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b827, 7);  mov(memd[ds, eax + 14], 0x101b_da04); /* mov dword [eax+0xe], 0x101bda04 */
            ii(0x1015_b82e, 5);  jmp(0x1015_bcc1, 0x48e); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b833:
            ii(0x1015_b833, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b836, 7);  mov(memd[ds, eax + 14], 0x101b_da14); /* mov dword [eax+0xe], 0x101bda14 */
            ii(0x1015_b83d, 5);  jmp(0x1015_bcc1, 0x47f); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b842:
            ii(0x1015_b842, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b845, 7);  mov(memd[ds, eax + 14], 0x101b_da24); /* mov dword [eax+0xe], 0x101bda24 */
            ii(0x1015_b84c, 5);  jmp(0x1015_bcc1, 0x470); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b851:
            ii(0x1015_b851, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b854, 7);  mov(memd[ds, eax + 14], 0x101b_da2e); /* mov dword [eax+0xe], 0x101bda2e */
            ii(0x1015_b85b, 5);  jmp(0x1015_bcc1, 0x461); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b860:
            ii(0x1015_b860, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b863, 7);  mov(memd[ds, eax + 14], 0x101b_da3e); /* mov dword [eax+0xe], 0x101bda3e */
            ii(0x1015_b86a, 5);  jmp(0x1015_bcc1, 0x452); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b86f:
            ii(0x1015_b86f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b872, 7);  mov(memd[ds, eax + 14], 0x101b_da4e); /* mov dword [eax+0xe], 0x101bda4e */
            ii(0x1015_b879, 5);  jmp(0x1015_bcc1, 0x443); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b87e:
            ii(0x1015_b87e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b881, 7);  mov(memd[ds, eax + 14], 0x101b_da5e); /* mov dword [eax+0xe], 0x101bda5e */
            ii(0x1015_b888, 5);  jmp(0x1015_bcc1, 0x434); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b88d:
            ii(0x1015_b88d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b890, 7);  mov(memd[ds, eax + 14], 0x101b_da65); /* mov dword [eax+0xe], 0x101bda65 */
            ii(0x1015_b897, 5);  jmp(0x1015_bcc1, 0x425); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b89c:
            ii(0x1015_b89c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b89f, 7);  mov(memd[ds, eax + 14], 0x101b_da6f); /* mov dword [eax+0xe], 0x101bda6f */
            ii(0x1015_b8a6, 5);  jmp(0x1015_bcc1, 0x416); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b8ab:
            ii(0x1015_b8ab, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b8ae, 7);  mov(memd[ds, eax + 14], 0x101b_da79); /* mov dword [eax+0xe], 0x101bda79 */
            ii(0x1015_b8b5, 5);  jmp(0x1015_bcc1, 0x407); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b8ba:
            ii(0x1015_b8ba, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b8bd, 7);  mov(memd[ds, eax + 14], 0x101b_da83); /* mov dword [eax+0xe], 0x101bda83 */
            ii(0x1015_b8c4, 5);  jmp(0x1015_bcc1, 0x3f8); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b8c9:
            ii(0x1015_b8c9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b8cc, 7);  mov(memd[ds, eax + 14], 0x101b_da8d); /* mov dword [eax+0xe], 0x101bda8d */
            ii(0x1015_b8d3, 5);  jmp(0x1015_bcc1, 0x3e9); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b8d8:
            ii(0x1015_b8d8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b8db, 7);  mov(memd[ds, eax + 14], 0x101b_da94); /* mov dword [eax+0xe], 0x101bda94 */
            ii(0x1015_b8e2, 5);  jmp(0x1015_bcc1, 0x3da); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b8e7:
            ii(0x1015_b8e7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b8ea, 7);  mov(memd[ds, eax + 14], 0x101b_da9b); /* mov dword [eax+0xe], 0x101bda9b */
            ii(0x1015_b8f1, 5);  jmp(0x1015_bcc1, 0x3cb); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b8f6:
            ii(0x1015_b8f6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b8f9, 7);  mov(memd[ds, eax + 14], 0x101b_daab); /* mov dword [eax+0xe], 0x101bdaab */
            ii(0x1015_b900, 5);  jmp(0x1015_bcc1, 0x3bc); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b905:
            ii(0x1015_b905, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b908, 7);  mov(memd[ds, eax + 14], 0x101b_daaf); /* mov dword [eax+0xe], 0x101bdaaf */
            ii(0x1015_b90f, 5);  jmp(0x1015_bcc1, 0x3ad); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b914:
            ii(0x1015_b914, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b917, 7);  mov(memd[ds, eax + 14], 0x101b_dab3); /* mov dword [eax+0xe], 0x101bdab3 */
            ii(0x1015_b91e, 5);  jmp(0x1015_bcc1, 0x39e); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b923:
            ii(0x1015_b923, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b926, 7);  mov(memd[ds, eax + 14], 0x101b_daba); /* mov dword [eax+0xe], 0x101bdaba */
            ii(0x1015_b92d, 5);  jmp(0x1015_bcc1, 0x38f); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b932:
            ii(0x1015_b932, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b935, 7);  mov(memd[ds, eax + 14], 0x101b_dacd); /* mov dword [eax+0xe], 0x101bdacd */
            ii(0x1015_b93c, 5);  jmp(0x1015_bcc1, 0x380); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b941:
            ii(0x1015_b941, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b944, 7);  mov(memd[ds, eax + 14], 0x101b_dae0); /* mov dword [eax+0xe], 0x101bdae0 */
            ii(0x1015_b94b, 5);  jmp(0x1015_bcc1, 0x371); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b950:
            ii(0x1015_b950, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b953, 7);  mov(memd[ds, eax + 14], 0x101b_daf3); /* mov dword [eax+0xe], 0x101bdaf3 */
            ii(0x1015_b95a, 5);  jmp(0x1015_bcc1, 0x362); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b95f:
            ii(0x1015_b95f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b962, 7);  mov(memd[ds, eax + 14], 0x101b_db06); /* mov dword [eax+0xe], 0x101bdb06 */
            ii(0x1015_b969, 5);  jmp(0x1015_bcc1, 0x353); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b96e:
            ii(0x1015_b96e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b971, 7);  mov(memd[ds, eax + 14], 0x101b_db19); /* mov dword [eax+0xe], 0x101bdb19 */
            ii(0x1015_b978, 5);  jmp(0x1015_bcc1, 0x344); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b97d:
            ii(0x1015_b97d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b980, 7);  mov(memd[ds, eax + 14], 0x101b_db2c); /* mov dword [eax+0xe], 0x101bdb2c */
            ii(0x1015_b987, 5);  jmp(0x1015_bcc1, 0x335); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b98c:
            ii(0x1015_b98c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b98f, 7);  mov(memd[ds, eax + 14], 0x101b_db3f); /* mov dword [eax+0xe], 0x101bdb3f */
            ii(0x1015_b996, 5);  jmp(0x1015_bcc1, 0x326); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b99b:
            ii(0x1015_b99b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b99e, 7);  mov(memd[ds, eax + 14], 0x101b_db52); /* mov dword [eax+0xe], 0x101bdb52 */
            ii(0x1015_b9a5, 5);  jmp(0x1015_bcc1, 0x317); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b9aa:
            ii(0x1015_b9aa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b9ad, 7);  mov(memd[ds, eax + 14], 0x101b_db68); /* mov dword [eax+0xe], 0x101bdb68 */
            ii(0x1015_b9b4, 5);  jmp(0x1015_bcc1, 0x308); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b9b9:
            ii(0x1015_b9b9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b9bc, 7);  mov(memd[ds, eax + 14], 0x101b_db78); /* mov dword [eax+0xe], 0x101bdb78 */
            ii(0x1015_b9c3, 5);  jmp(0x1015_bcc1, 0x2f9); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b9c8:
            ii(0x1015_b9c8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b9cb, 7);  mov(memd[ds, eax + 14], 0x101b_db88); /* mov dword [eax+0xe], 0x101bdb88 */
            ii(0x1015_b9d2, 5);  jmp(0x1015_bcc1, 0x2ea); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b9d7:
            ii(0x1015_b9d7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b9da, 7);  mov(memd[ds, eax + 14], 0x101b_db9b); /* mov dword [eax+0xe], 0x101bdb9b */
            ii(0x1015_b9e1, 5);  jmp(0x1015_bcc1, 0x2db); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b9e6:
            ii(0x1015_b9e6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b9e9, 7);  mov(memd[ds, eax + 14], 0x101b_dbae); /* mov dword [eax+0xe], 0x101bdbae */
            ii(0x1015_b9f0, 5);  jmp(0x1015_bcc1, 0x2cc); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_b9f5:
            ii(0x1015_b9f5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_b9f8, 7);  mov(memd[ds, eax + 14], 0x101b_dbc1); /* mov dword [eax+0xe], 0x101bdbc1 */
            ii(0x1015_b9ff, 5);  jmp(0x1015_bcc1, 0x2bd); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_ba04:
            ii(0x1015_ba04, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ba07, 7);  mov(memd[ds, eax + 14], 0x101b_dbd4); /* mov dword [eax+0xe], 0x101bdbd4 */
            ii(0x1015_ba0e, 5);  jmp(0x1015_bcc1, 0x2ae); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_ba13:
            ii(0x1015_ba13, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ba16, 7);  mov(memd[ds, eax + 14], 0x101b_dbe7); /* mov dword [eax+0xe], 0x101bdbe7 */
            ii(0x1015_ba1d, 5);  jmp(0x1015_bcc1, 0x29f); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_ba22:
            ii(0x1015_ba22, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ba25, 7);  mov(memd[ds, eax + 14], 0x101b_dbfa); /* mov dword [eax+0xe], 0x101bdbfa */
            ii(0x1015_ba2c, 5);  jmp(0x1015_bcc1, 0x290); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_ba31:
            ii(0x1015_ba31, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ba34, 7);  mov(memd[ds, eax + 14], 0x101b_dc0a); /* mov dword [eax+0xe], 0x101bdc0a */
            ii(0x1015_ba3b, 5);  jmp(0x1015_bcc1, 0x281); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_ba40:
            ii(0x1015_ba40, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ba43, 7);  mov(memd[ds, eax + 14], 0x101b_dc17); /* mov dword [eax+0xe], 0x101bdc17 */
            ii(0x1015_ba4a, 5);  jmp(0x1015_bcc1, 0x272); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_ba4f:
            ii(0x1015_ba4f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ba52, 7);  mov(memd[ds, eax + 14], 0x101b_dc24); /* mov dword [eax+0xe], 0x101bdc24 */
            ii(0x1015_ba59, 5);  jmp(0x1015_bcc1, 0x263); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_ba5e:
            ii(0x1015_ba5e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ba61, 7);  mov(memd[ds, eax + 14], 0x101b_dc37); /* mov dword [eax+0xe], 0x101bdc37 */
            ii(0x1015_ba68, 5);  jmp(0x1015_bcc1, 0x254); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_ba6d:
            ii(0x1015_ba6d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ba70, 7);  mov(memd[ds, eax + 14], 0x101b_dc4a); /* mov dword [eax+0xe], 0x101bdc4a */
            ii(0x1015_ba77, 5);  jmp(0x1015_bcc1, 0x245); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_ba7c:
            ii(0x1015_ba7c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ba7f, 7);  mov(memd[ds, eax + 14], 0x101b_dc5d); /* mov dword [eax+0xe], 0x101bdc5d */
            ii(0x1015_ba86, 5);  jmp(0x1015_bcc1, 0x236); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_ba8b:
            ii(0x1015_ba8b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ba8e, 7);  mov(memd[ds, eax + 14], 0x101b_dc70); /* mov dword [eax+0xe], 0x101bdc70 */
            ii(0x1015_ba95, 5);  jmp(0x1015_bcc1, 0x227); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_ba9a:
            ii(0x1015_ba9a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ba9d, 7);  mov(memd[ds, eax + 14], 0x101b_dc80); /* mov dword [eax+0xe], 0x101bdc80 */
            ii(0x1015_baa4, 5);  jmp(0x1015_bcc1, 0x218); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_baa9:
            ii(0x1015_baa9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_baac, 7);  mov(memd[ds, eax + 14], 0x101b_dc93); /* mov dword [eax+0xe], 0x101bdc93 */
            ii(0x1015_bab3, 5);  jmp(0x1015_bcc1, 0x209); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_bab8:
            ii(0x1015_bab8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_babb, 7);  mov(memd[ds, eax + 14], 0x101b_dca9); /* mov dword [eax+0xe], 0x101bdca9 */
            ii(0x1015_bac2, 5);  jmp(0x1015_bcc1, 0x1fa); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_bac7:
            ii(0x1015_bac7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_baca, 7);  mov(memd[ds, eax + 14], 0x101b_dcbc); /* mov dword [eax+0xe], 0x101bdcbc */
            ii(0x1015_bad1, 5);  jmp(0x1015_bcc1, 0x1eb); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_bad6:
            ii(0x1015_bad6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_bad9, 7);  mov(memd[ds, eax + 14], 0x101b_dcd5); /* mov dword [eax+0xe], 0x101bdcd5 */
            ii(0x1015_bae0, 5);  jmp(0x1015_bcc1, 0x1dc); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_bae5:
            ii(0x1015_bae5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_bae8, 7);  mov(memd[ds, eax + 14], 0x101b_dcee); /* mov dword [eax+0xe], 0x101bdcee */
            ii(0x1015_baef, 5);  jmp(0x1015_bcc1, 0x1cd); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_baf4:
            ii(0x1015_baf4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_baf7, 7);  mov(memd[ds, eax + 14], 0x101b_dd0a); /* mov dword [eax+0xe], 0x101bdd0a */
            ii(0x1015_bafe, 5);  jmp(0x1015_bcc1, 0x1be); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_bb03:
            ii(0x1015_bb03, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_bb06, 7);  mov(memd[ds, eax + 14], 0x101b_dd23); /* mov dword [eax+0xe], 0x101bdd23 */
            ii(0x1015_bb0d, 5);  jmp(0x1015_bcc1, 0x1af); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_bb12:
            ii(0x1015_bb12, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_bb15, 7);  mov(memd[ds, eax + 14], 0x101b_dd36); /* mov dword [eax+0xe], 0x101bdd36 */
            ii(0x1015_bb1c, 5);  jmp(0x1015_bcc1, 0x1a0); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_bb21:
            ii(0x1015_bb21, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_bb24, 7);  mov(memd[ds, eax + 14], 0x101b_dd49); /* mov dword [eax+0xe], 0x101bdd49 */
            ii(0x1015_bb2b, 5);  jmp(0x1015_bcc1, 0x191); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_bb30:
            ii(0x1015_bb30, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_bb33, 7);  mov(memd[ds, eax + 14], 0x101b_dd5c); /* mov dword [eax+0xe], 0x101bdd5c */
            ii(0x1015_bb3a, 5);  jmp(0x1015_bcc1, 0x182); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        l_0x1015_bb3f:
            ii(0x1015_bb3f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_bb42, 7);  mov(memd[ds, eax + 14], 0x101b_d924); /* mov dword [eax+0xe], 0x101bd924 */
            ii(0x1015_bb49, 5);  jmp(0x1015_bcc1, 0x173); goto l_0x1015_bcc1;/* jmp 0x1015bcc1 */
        //  ii(0x1015_bb4e, 2);  mov(eax, eax);                        /* mov eax, eax */
        //  ii(0x1015_bb50, 336);  /* Служебная область с абсолютными адресами переходов. (0x1015_b734, 0x1015_b743, 0x1015_b752, 0x1015_b761, 0x1015_b770, 0x1015_b77f, 0x1015_b78e, 0x1015_b79d, 0x1015_b7ac, 0x1015_b7bb, 0x1015_b7ca, 0x1015_b7d9, 0x1015_bb3f, 0x1015_bb3f, 0x1015_bb3f, 0x1015_bb3f, 0x1015_bb3f, 0x1015_bb3f, 0x1015_bb3f, 0x1015_bb3f, 0x1015_bb3f, 0x1015_b7e8, 0x1015_b7f7, 0x1015_b806, 0x1015_b815, 0x1015_b824, 0x1015_bb3f, 0x1015_b833, 0x1015_b842, 0x1015_b851, 0x1015_b860, 0x1015_bb3f, 0x1015_b86f, 0x1015_b87e, 0x1015_b88d, 0x1015_b8ab, 0x1015_b89c, 0x1015_b8ba, 0x1015_b8c9, 0x1015_b8d8, 0x1015_b8e7, 0x1015_b8f6, 0x1015_b905, 0x1015_bb3f, 0x1015_bb3f, 0x1015_bb3f, 0x1015_bb3f, 0x1015_b914, 0x1015_b923, 0x1015_b932, 0x1015_b941, 0x1015_b950, 0x1015_b95f, 0x1015_b96e, 0x1015_b97d, 0x1015_b98c, 0x1015_b99b, 0x1015_b9aa, 0x1015_b9b9, 0x1015_b9c8, 0x1015_b9d7, 0x1015_b9e6, 0x1015_b9f5, 0x1015_ba04, 0x1015_ba13, 0x1015_ba22, 0x1015_ba31, 0x1015_ba40, 0x1015_ba4f, 0x1015_ba5e, 0x1015_ba6d, 0x1015_ba7c, 0x1015_ba8b, 0x1015_ba9a, 0x1015_baa9, 0x1015_bab8, 0x1015_bac7, 0x1015_bad6, 0x1015_bae5, 0x1015_baf4, 0x1015_bb03, 0x1015_bb12, 0x1015_bb21, 0x1015_bb30). */
        l_0x1015_bca0:
            ii(0x1015_bca0, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1015_bca3, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1015_bca6, 5);  cmp(memw[ss, ebp - 32], 0x53);        /* cmp word [ebp-0x20], 0x53 */
            ii(0x1015_bcab, 6);  if(ja(0x1015_bb3f, -0x172)) goto l_0x1015_bb3f;/* ja 0x1015bb3f */
            ii(0x1015_bcb1, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_bcb3, 4);  mov(ax, memw[ss, ebp - 32]);          /* mov ax, [ebp-0x20] */
            ii(0x1015_bcb7, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1015_bcba, 7);  /* jmp dword [cs:eax+0x1015bb50] */
            switch (jmp_abs_switch(memd[cs, eax + 0x1015_bb50]))
            {
                case 0x1015_b734:
                    goto l_0x1015_b734;
                case 0x1015_b743:
                    goto l_0x1015_b743;
                case 0x1015_b752:
                    goto l_0x1015_b752;
                case 0x1015_b761:
                    goto l_0x1015_b761;
                case 0x1015_b770:
                    goto l_0x1015_b770;
                case 0x1015_b77f:
                    goto l_0x1015_b77f;
                case 0x1015_b78e:
                    goto l_0x1015_b78e;
                case 0x1015_b79d:
                    goto l_0x1015_b79d;
                case 0x1015_b7ac:
                    goto l_0x1015_b7ac;
                case 0x1015_b7bb:
                    goto l_0x1015_b7bb;
                case 0x1015_b7ca:
                    goto l_0x1015_b7ca;
                case 0x1015_b7d9:
                    goto l_0x1015_b7d9;
                case 0x1015_b7e8:
                    goto l_0x1015_b7e8;
                case 0x1015_b7f7:
                    goto l_0x1015_b7f7;
                case 0x1015_b806:
                    goto l_0x1015_b806;
                case 0x1015_b815:
                    goto l_0x1015_b815;
                case 0x1015_b824:
                    goto l_0x1015_b824;
                case 0x1015_b833:
                    goto l_0x1015_b833;
                case 0x1015_b842:
                    goto l_0x1015_b842;
                case 0x1015_b851:
                    goto l_0x1015_b851;
                case 0x1015_b860:
                    goto l_0x1015_b860;
                case 0x1015_b86f:
                    goto l_0x1015_b86f;
                case 0x1015_b87e:
                    goto l_0x1015_b87e;
                case 0x1015_b88d:
                    goto l_0x1015_b88d;
                case 0x1015_b89c:
                    goto l_0x1015_b89c;
                case 0x1015_b8ab:
                    goto l_0x1015_b8ab;
                case 0x1015_b8ba:
                    goto l_0x1015_b8ba;
                case 0x1015_b8c9:
                    goto l_0x1015_b8c9;
                case 0x1015_b8d8:
                    goto l_0x1015_b8d8;
                case 0x1015_b8e7:
                    goto l_0x1015_b8e7;
                case 0x1015_b8f6:
                    goto l_0x1015_b8f6;
                case 0x1015_b905:
                    goto l_0x1015_b905;
                case 0x1015_b914:
                    goto l_0x1015_b914;
                case 0x1015_b923:
                    goto l_0x1015_b923;
                case 0x1015_b932:
                    goto l_0x1015_b932;
                case 0x1015_b941:
                    goto l_0x1015_b941;
                case 0x1015_b950:
                    goto l_0x1015_b950;
                case 0x1015_b95f:
                    goto l_0x1015_b95f;
                case 0x1015_b96e:
                    goto l_0x1015_b96e;
                case 0x1015_b97d:
                    goto l_0x1015_b97d;
                case 0x1015_b98c:
                    goto l_0x1015_b98c;
                case 0x1015_b99b:
                    goto l_0x1015_b99b;
                case 0x1015_b9aa:
                    goto l_0x1015_b9aa;
                case 0x1015_b9b9:
                    goto l_0x1015_b9b9;
                case 0x1015_b9c8:
                    goto l_0x1015_b9c8;
                case 0x1015_b9d7:
                    goto l_0x1015_b9d7;
                case 0x1015_b9e6:
                    goto l_0x1015_b9e6;
                case 0x1015_b9f5:
                    goto l_0x1015_b9f5;
                case 0x1015_ba04:
                    goto l_0x1015_ba04;
                case 0x1015_ba13:
                    goto l_0x1015_ba13;
                case 0x1015_ba22:
                    goto l_0x1015_ba22;
                case 0x1015_ba31:
                    goto l_0x1015_ba31;
                case 0x1015_ba40:
                    goto l_0x1015_ba40;
                case 0x1015_ba4f:
                    goto l_0x1015_ba4f;
                case 0x1015_ba5e:
                    goto l_0x1015_ba5e;
                case 0x1015_ba6d:
                    goto l_0x1015_ba6d;
                case 0x1015_ba7c:
                    goto l_0x1015_ba7c;
                case 0x1015_ba8b:
                    goto l_0x1015_ba8b;
                case 0x1015_ba9a:
                    goto l_0x1015_ba9a;
                case 0x1015_baa9:
                    goto l_0x1015_baa9;
                case 0x1015_bab8:
                    goto l_0x1015_bab8;
                case 0x1015_bac7:
                    goto l_0x1015_bac7;
                case 0x1015_bad6:
                    goto l_0x1015_bad6;
                case 0x1015_bae5:
                    goto l_0x1015_bae5;
                case 0x1015_baf4:
                    goto l_0x1015_baf4;
                case 0x1015_bb03:
                    goto l_0x1015_bb03;
                case 0x1015_bb12:
                    goto l_0x1015_bb12;
                case 0x1015_bb21:
                    goto l_0x1015_bb21;
                case 0x1015_bb30:
                    goto l_0x1015_bb30;
                case 0x1015_bb3f:
                    goto l_0x1015_bb3f;
                default:
                    throw new NotImplementedException();
            }
        l_0x1015_bcc1:
            ii(0x1015_bcc1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_bcc3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_bcc4, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_bcc5, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_bcc6, 1);  pop(edx);                             /* pop edx */
            ii(0x1015_bcc7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_bcc8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_bcc9, 1);  ret();                                /* ret */
        }
    }
}
