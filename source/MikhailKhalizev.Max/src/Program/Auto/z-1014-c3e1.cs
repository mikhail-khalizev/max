using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_c3e1-142c0a96")]
        public void Method_1014_c3e1()
        {
            ii(0x1014_c3e1, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_c3e6, 5); call(Definitions.sys_check_available_stack_size, 0x1_9967); /* call 0x10165d52 */
            ii(0x1014_c3eb, 1); push(ebx);                              /* push ebx */
            ii(0x1014_c3ec, 1); push(ecx);                              /* push ecx */
            ii(0x1014_c3ed, 1); push(esi);                              /* push esi */
            ii(0x1014_c3ee, 1); push(edi);                              /* push edi */
            ii(0x1014_c3ef, 1); push(ebp);                              /* push ebp */
            ii(0x1014_c3f0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_c3f2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_c3f8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_c3fb, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_c3fe, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x1014_c403, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c406, 3); add(edx, 8);                            /* add edx, 0x8 */
            ii(0x1014_c409, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c40c, 5); call(0x1013_ba86, -0x1_098b);           /* call 0x1013ba86 */
            ii(0x1014_c411, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c414, 3); add(edx, 0x7c);                         /* add edx, 0x7c */
            ii(0x1014_c417, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c41a, 5); call(0x1013_bbb0, -0x1_086f);           /* call 0x1013bbb0 */
            ii(0x1014_c41f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c422, 3); add(edx, 0x12);                         /* add edx, 0x12 */
            ii(0x1014_c425, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c428, 5); call(0x1013_bbe5, -0x1_0848);           /* call 0x1013bbe5 */
            ii(0x1014_c42d, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c430, 3); add(edx, 0x16);                         /* add edx, 0x16 */
            ii(0x1014_c433, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c436, 5); call(0x1013_bb7b, -0x1_08c0);           /* call 0x1013bb7b */
            ii(0x1014_c43b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c43e, 3); add(edx, 0x18);                         /* add edx, 0x18 */
            ii(0x1014_c441, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c444, 5); call(0x1013_bb7b, -0x1_08ce);           /* call 0x1013bb7b */
            ii(0x1014_c449, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c44c, 3); add(edx, 0x1a);                         /* add edx, 0x1a */
            ii(0x1014_c44f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c452, 5); call(0x1013_bb7b, -0x1_08dc);           /* call 0x1013bb7b */
            ii(0x1014_c457, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c45a, 3); add(edx, 0x1c);                         /* add edx, 0x1c */
            ii(0x1014_c45d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c460, 5); call(0x1013_bb7b, -0x1_08ea);           /* call 0x1013bb7b */
            ii(0x1014_c465, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c468, 7); cmp(memd[ds, eax + 167], 0);            /* cmp dword [eax+0xa7], 0x0 */
            ii(0x1014_c46f, 2); if(jz(0x1014_c47f, 0xe)) goto l_0x1014_c47f; /* jz 0x1014c47f */
            ii(0x1014_c471, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c474, 6); mov(eax, memd[ds, eax + 167]);          /* mov eax, [eax+0xa7] */
            ii(0x1014_c47a, 5); call(Definitions.sys_delete, 0x1_9ae5); /* call 0x10165f64 */
        l_0x1014_c47f:
            ii(0x1014_c47f, 3); lea(edx, memd[ss, ebp - 12]);           /* lea edx, [ebp-0xc] */
            ii(0x1014_c482, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c485, 5); call(0x1013_bb7b, -0x1_090f);           /* call 0x1013bb7b */
            ii(0x1014_c48a, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1014_c48e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_c490, 2); if(jnz(0x1014_c4a1, 0xf)) goto l_0x1014_c4a1; /* jnz 0x1014c4a1 */
            ii(0x1014_c492, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c495, 10); mov(memd[ds, eax + 167], 0);           /* mov dword [eax+0xa7], 0x0 */
            ii(0x1014_c49f, 2); jmp(0x1014_c4dd, 0x3c); goto l_0x1014_c4dd; /* jmp 0x1014c4dd */
        l_0x1014_c4a1:
            ii(0x1014_c4a1, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1014_c4a5, 1); inc(eax);                               /* inc eax */
            ii(0x1014_c4a6, 5); call(Definitions.sys_new_arr, 0x1_9b65); /* call 0x10166010 */
            ii(0x1014_c4ab, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_c4ad, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c4b0, 6); mov(memd[ds, eax + 167], edx);          /* mov [eax+0xa7], edx */
            ii(0x1014_c4b6, 4); movsx(ebx, memw[ss, ebp - 12]);         /* movsx ebx, word [ebp-0xc] */
            ii(0x1014_c4ba, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c4bd, 6); mov(edx, memd[ds, eax + 167]);          /* mov edx, [eax+0xa7] */
            ii(0x1014_c4c3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c4c6, 5); call(0x1013_ba86, -0x1_0a45);           /* call 0x1013ba86 */
            ii(0x1014_c4cb, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1014_c4cf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c4d2, 6); mov(eax, memd[ds, eax + 167]);          /* mov eax, [eax+0xa7] */
            ii(0x1014_c4d8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_c4da, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
        l_0x1014_c4dd:
            ii(0x1014_c4dd, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c4e0, 6); add(edx, 0xd9);                         /* add edx, 0xd9 */
            ii(0x1014_c4e6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c4e9, 5); call(0x1013_bb7b, -0x1_0973);           /* call 0x1013bb7b */
            ii(0x1014_c4ee, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c4f1, 6); add(edx, 0xdb);                         /* add edx, 0xdb */
            ii(0x1014_c4f7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c4fa, 5); call(0x1013_bb7b, -0x1_0984);           /* call 0x1013bb7b */
            ii(0x1014_c4ff, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c502, 3); add(edx, 0x26);                         /* add edx, 0x26 */
            ii(0x1014_c505, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c508, 5); call(0x1013_bb46, -0x1_09c7);           /* call 0x1013bb46 */
            ii(0x1014_c50d, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c510, 3); add(edx, 0x27);                         /* add edx, 0x27 */
            ii(0x1014_c513, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c516, 5); call(0x1013_bb46, -0x1_09d5);           /* call 0x1013bb46 */
            ii(0x1014_c51b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c51e, 3); add(edx, 0x28);                         /* add edx, 0x28 */
            ii(0x1014_c521, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c524, 5); call(0x1013_bb46, -0x1_09e3);           /* call 0x1013bb46 */
            ii(0x1014_c529, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c52c, 3); add(edx, 0x29);                         /* add edx, 0x29 */
            ii(0x1014_c52f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c532, 5); call(0x1013_bb46, -0x1_09f1);           /* call 0x1013bb46 */
            ii(0x1014_c537, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x1014_c53c, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c53f, 6); add(edx, 0xab);                         /* add edx, 0xab */
            ii(0x1014_c545, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c548, 5); call(0x1013_ba86, -0x1_0ac7);           /* call 0x1013ba86 */
            ii(0x1014_c54d, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x1014_c552, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c555, 6); add(edx, 0xb0);                         /* add edx, 0xb0 */
            ii(0x1014_c55b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c55e, 5); call(0x1013_ba86, -0x1_0add);           /* call 0x1013ba86 */
            ii(0x1014_c563, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c566, 3); add(edx, 0x2a);                         /* add edx, 0x2a */
            ii(0x1014_c569, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c56c, 5); call(0x1013_bb46, -0x1_0a2b);           /* call 0x1013bb46 */
            ii(0x1014_c571, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c574, 3); add(edx, 0x2b);                         /* add edx, 0x2b */
            ii(0x1014_c577, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c57a, 5); call(0x1013_bb46, -0x1_0a39);           /* call 0x1013bb46 */
            ii(0x1014_c57f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c582, 3); add(edx, 0x2c);                         /* add edx, 0x2c */
            ii(0x1014_c585, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c588, 5); call(0x1013_bb46, -0x1_0a47);           /* call 0x1013bb46 */
            ii(0x1014_c58d, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c590, 3); add(edx, 0x2d);                         /* add edx, 0x2d */
            ii(0x1014_c593, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c596, 5); call(0x1013_bb46, -0x1_0a55);           /* call 0x1013bb46 */
            ii(0x1014_c59b, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x1014_c5a0, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c5a3, 6); add(edx, 0xb5);                         /* add edx, 0xb5 */
            ii(0x1014_c5a9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c5ac, 5); call(0x1013_ba86, -0x1_0b2b);           /* call 0x1013ba86 */
            ii(0x1014_c5b1, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x1014_c5b6, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c5b9, 6); add(edx, 0xc5);                         /* add edx, 0xc5 */
            ii(0x1014_c5bf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c5c2, 5); call(0x1013_ba86, -0x1_0b41);           /* call 0x1013ba86 */
            ii(0x1014_c5c7, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c5ca, 3); add(edx, 0x2e);                         /* add edx, 0x2e */
            ii(0x1014_c5cd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c5d0, 5); call(0x1013_bb46, -0x1_0a8f);           /* call 0x1013bb46 */
            ii(0x1014_c5d5, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c5d8, 3); add(edx, 0x2f);                         /* add edx, 0x2f */
            ii(0x1014_c5db, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c5de, 5); call(0x1015_5410, 0x8e2d);              /* call 0x10155410 */
            ii(0x1014_c5e3, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c5e6, 3); add(edx, 0x30);                         /* add edx, 0x30 */
            ii(0x1014_c5e9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c5ec, 5); call(0x1015_5410, 0x8e1f);              /* call 0x10155410 */
            ii(0x1014_c5f1, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c5f4, 3); add(edx, 0x31);                         /* add edx, 0x31 */
            ii(0x1014_c5f7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c5fa, 5); call(0x1013_bb7b, -0x1_0a84);           /* call 0x1013bb7b */
            ii(0x1014_c5ff, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c602, 3); add(edx, 0x33);                         /* add edx, 0x33 */
            ii(0x1014_c605, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c608, 5); call(0x1013_bb7b, -0x1_0a92);           /* call 0x1013bb7b */
            ii(0x1014_c60d, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c610, 3); add(edx, 0x35);                         /* add edx, 0x35 */
            ii(0x1014_c613, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c616, 5); call(0x1013_bb7b, -0x1_0aa0);           /* call 0x1013bb7b */
            ii(0x1014_c61b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c61e, 3); add(edx, 0x37);                         /* add edx, 0x37 */
            ii(0x1014_c621, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c624, 5); call(0x1013_bb7b, -0x1_0aae);           /* call 0x1013bb7b */
            ii(0x1014_c629, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c62c, 3); add(edx, 0x39);                         /* add edx, 0x39 */
            ii(0x1014_c62f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c632, 5); call(0x1013_bb7b, -0x1_0abc);           /* call 0x1013bb7b */
            ii(0x1014_c637, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c63a, 6); add(edx, 0xd5);                         /* add edx, 0xd5 */
            ii(0x1014_c640, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c643, 5); call(0x1013_bb7b, -0x1_0acd);           /* call 0x1013bb7b */
            ii(0x1014_c648, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c64b, 6); add(edx, 0xd7);                         /* add edx, 0xd7 */
            ii(0x1014_c651, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c654, 5); call(0x1013_bb7b, -0x1_0ade);           /* call 0x1013bb7b */
            ii(0x1014_c659, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c65c, 3); add(edx, 0x3b);                         /* add edx, 0x3b */
            ii(0x1014_c65f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c662, 5); call(0x1013_bb7b, -0x1_0aec);           /* call 0x1013bb7b */
            ii(0x1014_c667, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1014_c66c, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c66f, 3); add(edx, 0x3d);                         /* add edx, 0x3d */
            ii(0x1014_c672, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c675, 5); call(0x1013_ba86, -0x1_0bf4);           /* call 0x1013ba86 */
            ii(0x1014_c67a, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1014_c67f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c682, 3); add(edx, 0x3e);                         /* add edx, 0x3e */
            ii(0x1014_c685, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c688, 5); call(0x1013_ba86, -0x1_0c07);           /* call 0x1013ba86 */
            ii(0x1014_c68d, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1014_c692, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c695, 3); add(edx, 0x3f);                         /* add edx, 0x3f */
            ii(0x1014_c698, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c69b, 5); call(0x1013_ba86, -0x1_0c1a);           /* call 0x1013ba86 */
            ii(0x1014_c6a0, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1014_c6a5, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c6a8, 3); add(edx, 0x40);                         /* add edx, 0x40 */
            ii(0x1014_c6ab, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c6ae, 5); call(0x1013_ba86, -0x1_0c2d);           /* call 0x1013ba86 */
            ii(0x1014_c6b3, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1014_c6b8, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c6bb, 6); add(edx, 0xa6);                         /* add edx, 0xa6 */
            ii(0x1014_c6c1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c6c4, 5); call(0x1013_ba86, -0x1_0c43);           /* call 0x1013ba86 */
            ii(0x1014_c6c9, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c6cc, 3); add(edx, 0x41);                         /* add edx, 0x41 */
            ii(0x1014_c6cf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c6d2, 5); call(0x1013_bb7b, -0x1_0b5c);           /* call 0x1013bb7b */
            ii(0x1014_c6d7, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c6da, 3); add(edx, 0x43);                         /* add edx, 0x43 */
            ii(0x1014_c6dd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c6e0, 5); call(0x1013_bb7b, -0x1_0b6a);           /* call 0x1013bb7b */
            ii(0x1014_c6e5, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c6e8, 3); add(edx, 0x45);                         /* add edx, 0x45 */
            ii(0x1014_c6eb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c6ee, 5); call(0x1013_bb46, -0x1_0bad);           /* call 0x1013bb46 */
            ii(0x1014_c6f3, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c6f6, 3); add(edx, 0x46);                         /* add edx, 0x46 */
            ii(0x1014_c6f9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c6fc, 5); call(0x1013_bb46, -0x1_0bbb);           /* call 0x1013bb46 */
            ii(0x1014_c701, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c704, 3); add(edx, 0x47);                         /* add edx, 0x47 */
            ii(0x1014_c707, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c70a, 5); call(0x1013_bb46, -0x1_0bc9);           /* call 0x1013bb46 */
            ii(0x1014_c70f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c712, 3); add(edx, 0x48);                         /* add edx, 0x48 */
            ii(0x1014_c715, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c718, 5); call(0x1013_bb46, -0x1_0bd7);           /* call 0x1013bb46 */
            ii(0x1014_c71d, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c720, 3); add(edx, 0x49);                         /* add edx, 0x49 */
            ii(0x1014_c723, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c726, 5); call(0x1013_bb46, -0x1_0be5);           /* call 0x1013bb46 */
            ii(0x1014_c72b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c72e, 3); add(edx, 0x4a);                         /* add edx, 0x4a */
            ii(0x1014_c731, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c734, 5); call(0x1013_bb46, -0x1_0bf3);           /* call 0x1013bb46 */
            ii(0x1014_c739, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c73c, 3); add(edx, 0x4b);                         /* add edx, 0x4b */
            ii(0x1014_c73f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c742, 5); call(0x1013_bb46, -0x1_0c01);           /* call 0x1013bb46 */
            ii(0x1014_c747, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c74a, 3); add(edx, 0x4c);                         /* add edx, 0x4c */
            ii(0x1014_c74d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c750, 5); call(0x1013_bb46, -0x1_0c0f);           /* call 0x1013bb46 */
            ii(0x1014_c755, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c758, 3); add(edx, 0x4d);                         /* add edx, 0x4d */
            ii(0x1014_c75b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c75e, 5); call(0x1013_bb46, -0x1_0c1d);           /* call 0x1013bb46 */
            ii(0x1014_c763, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c766, 3); add(edx, 0x4e);                         /* add edx, 0x4e */
            ii(0x1014_c769, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c76c, 5); call(0x1013_bb46, -0x1_0c2b);           /* call 0x1013bb46 */
            ii(0x1014_c771, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c774, 3); add(edx, 0x50);                         /* add edx, 0x50 */
            ii(0x1014_c777, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c77a, 5); call(0x1013_bb46, -0x1_0c39);           /* call 0x1013bb46 */
            ii(0x1014_c77f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c782, 3); add(edx, 0x51);                         /* add edx, 0x51 */
            ii(0x1014_c785, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c788, 5); call(0x1013_bb11, -0x1_0c7c);           /* call 0x1013bb11 */
            ii(0x1014_c78d, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c790, 3); add(edx, 0x52);                         /* add edx, 0x52 */
            ii(0x1014_c793, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c796, 5); call(0x1013_bb7b, -0x1_0c20);           /* call 0x1013bb7b */
            ii(0x1014_c79b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c79e, 3); add(edx, 0x54);                         /* add edx, 0x54 */
            ii(0x1014_c7a1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c7a4, 5); call(0x1013_bb46, -0x1_0c63);           /* call 0x1013bb46 */
            ii(0x1014_c7a9, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c7ac, 3); add(edx, 0x55);                         /* add edx, 0x55 */
            ii(0x1014_c7af, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c7b2, 5); call(0x1013_bb11, -0x1_0ca6);           /* call 0x1013bb11 */
            ii(0x1014_c7b7, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c7ba, 3); add(edx, 0x56);                         /* add edx, 0x56 */
            ii(0x1014_c7bd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c7c0, 5); call(0x1013_bb11, -0x1_0cb4);           /* call 0x1013bb11 */
            ii(0x1014_c7c5, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1014_c7ca, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c7cd, 3); add(edx, 0x57);                         /* add edx, 0x57 */
            ii(0x1014_c7d0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c7d3, 5); call(0x1013_ba86, -0x1_0d52);           /* call 0x1013ba86 */
            ii(0x1014_c7d8, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c7db, 3); add(edx, 0x58);                         /* add edx, 0x58 */
            ii(0x1014_c7de, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c7e1, 5); call(0x1013_bb46, -0x1_0ca0);           /* call 0x1013bb46 */
            ii(0x1014_c7e6, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c7e9, 3); add(edx, 0x59);                         /* add edx, 0x59 */
            ii(0x1014_c7ec, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c7ef, 5); call(0x1013_bb11, -0x1_0ce3);           /* call 0x1013bb11 */
            ii(0x1014_c7f4, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c7f7, 3); add(edx, 0x5a);                         /* add edx, 0x5a */
            ii(0x1014_c7fa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c7fd, 5); call(0x1013_bb11, -0x1_0cf1);           /* call 0x1013bb11 */
            ii(0x1014_c802, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1014_c807, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c80a, 3); add(edx, 0x5d);                         /* add edx, 0x5d */
            ii(0x1014_c80d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c810, 5); call(0x1013_ba86, -0x1_0d8f);           /* call 0x1013ba86 */
            ii(0x1014_c815, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c818, 3); add(edx, 0x5e);                         /* add edx, 0x5e */
            ii(0x1014_c81b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c81e, 5); call(0x1013_bb46, -0x1_0cdd);           /* call 0x1013bb46 */
            ii(0x1014_c823, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c826, 3); add(edx, 0x5f);                         /* add edx, 0x5f */
            ii(0x1014_c829, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c82c, 5); call(0x1013_bb46, -0x1_0ceb);           /* call 0x1013bb46 */
            ii(0x1014_c831, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c834, 3); add(edx, 0x6b);                         /* add edx, 0x6b */
            ii(0x1014_c837, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c83a, 5); call(0x1013_bb46, -0x1_0cf9);           /* call 0x1013bb46 */
            ii(0x1014_c83f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c842, 3); add(edx, 0x60);                         /* add edx, 0x60 */
            ii(0x1014_c845, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c848, 5); call(0x1013_bb46, -0x1_0d07);           /* call 0x1013bb46 */
            ii(0x1014_c84d, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c850, 3); add(edx, 0x61);                         /* add edx, 0x61 */
            ii(0x1014_c853, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c856, 5); call(0x1013_bb46, -0x1_0d15);           /* call 0x1013bb46 */
            ii(0x1014_c85b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c85e, 3); add(edx, 0x62);                         /* add edx, 0x62 */
            ii(0x1014_c861, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c864, 5); call(0x1013_bb46, -0x1_0d23);           /* call 0x1013bb46 */
            ii(0x1014_c869, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c86c, 3); add(edx, 0x63);                         /* add edx, 0x63 */
            ii(0x1014_c86f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c872, 5); call(0x1013_bb46, -0x1_0d31);           /* call 0x1013bb46 */
            ii(0x1014_c877, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c87a, 3); add(edx, 0x64);                         /* add edx, 0x64 */
            ii(0x1014_c87d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c880, 5); call(0x1013_bb46, -0x1_0d3f);           /* call 0x1013bb46 */
            ii(0x1014_c885, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c888, 3); add(edx, 0x7b);                         /* add edx, 0x7b */
            ii(0x1014_c88b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c88e, 5); call(0x1013_bb11, -0x1_0d82);           /* call 0x1013bb11 */
            ii(0x1014_c893, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c896, 3); add(edx, 0x7a);                         /* add edx, 0x7a */
            ii(0x1014_c899, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c89c, 5); call(0x1013_bb11, -0x1_0d90);           /* call 0x1013bb11 */
            ii(0x1014_c8a1, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c8a4, 3); add(edx, 0x78);                         /* add edx, 0x78 */
            ii(0x1014_c8a7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c8aa, 5); call(0x1013_bb7b, -0x1_0d34);           /* call 0x1013bb7b */
            ii(0x1014_c8af, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c8b2, 3); add(edx, 0x5b);                         /* add edx, 0x5b */
            ii(0x1014_c8b5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c8b8, 5); call(0x1013_bb11, -0x1_0dac);           /* call 0x1013bb11 */
            ii(0x1014_c8bd, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c8c0, 3); add(edx, 0x5c);                         /* add edx, 0x5c */
            ii(0x1014_c8c3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c8c6, 5); call(0x1013_bb11, -0x1_0dba);           /* call 0x1013bb11 */
            ii(0x1014_c8cb, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c8ce, 6); add(edx, 0xdd);                         /* add edx, 0xdd */
            ii(0x1014_c8d4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c8d7, 5); call(0x1013_bbe5, -0x1_0cf7);           /* call 0x1013bbe5 */
            ii(0x1014_c8dc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c8df, 7); and(memb[ds, eax + 222], -2 /* 0xfe */); /* and byte [eax+0xde], 0xfe */
            ii(0x1014_c8e6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c8e9, 3); mov(eax, memd[ds, eax + 118]);          /* mov eax, [eax+0x76] */
            ii(0x1014_c8ec, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_c8ef, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_c8f1, 2); if(jnz(0x1014_c8fa, 7)) goto l_0x1014_c8fa; /* jnz 0x1014c8fa */
            ii(0x1014_c8f3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c8f6, 4); inc(memw[ds, eax + 120]);               /* inc word [eax+0x78] */
        l_0x1014_c8fa:
            ii(0x1014_c8fa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c8fd, 5); call(0x1013_bc8c, -0x1_0c76);           /* call 0x1013bc8c */
            ii(0x1014_c902, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1014_c905, 3); add(ebx, 0x65);                         /* add ebx, 0x65 */
            ii(0x1014_c908, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_c90a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_c90c, 5); call(0x1007_6a34, -0xd_5edd);           /* call 0x10076a34 */
            ii(0x1014_c911, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_c914, 3); add(edx, 0x69);                         /* add edx, 0x69 */
            ii(0x1014_c917, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c91a, 5); call(0x1013_bb7b, -0x1_0da4);           /* call 0x1013bb7b */
            ii(0x1014_c91f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c922, 5); call(0x1013_bc8c, -0x1_0c9b);           /* call 0x1013bc8c */
            ii(0x1014_c927, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1014_c92a, 3); add(ebx, 0x6c);                         /* add ebx, 0x6c */
            ii(0x1014_c92d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_c92f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_c931, 5); call(0x100c_b77c, -0x8_11ba);           /* call 0x100cb77c */
            ii(0x1014_c936, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c939, 5); call(0x1013_bc8c, -0x1_0cb2);           /* call 0x1013bc8c */
            ii(0x1014_c93e, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1014_c941, 3); add(ebx, 0x70);                         /* add ebx, 0x70 */
            ii(0x1014_c944, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_c946, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_c948, 5); call(0x100a_b2a8, -0xa_16a5);           /* call 0x100ab2a8 */
            ii(0x1014_c94d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c950, 5); call(0x1013_bc8c, -0x1_0cc9);           /* call 0x1013bc8c */
            ii(0x1014_c955, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_c957, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c95a, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1014_c95f, 5); call(0x1007_6630, -0xd_6334);           /* call 0x10076630 */
            ii(0x1014_c964, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_c967, 5); call(0x1013_bc8c, -0x1_0ce0);           /* call 0x1013bc8c */
            ii(0x1014_c96c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_c96e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c971, 5); add(eax, 0x86);                         /* add eax, 0x86 */
            ii(0x1014_c976, 5); call(0x1007_6630, -0xd_634b);           /* call 0x10076630 */
            ii(0x1014_c97b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_c97e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c981, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1014_c984, 5); call(0x100c_fca8, -0x7_cce1);           /* call 0x100cfca8 */
            ii(0x1014_c989, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c98c, 4); cmp(memb[ds, eax + 62], 0x2a);          /* cmp byte [eax+0x3e], 0x2a */
            ii(0x1014_c990, 2); if(jz(0x1014_c99b, 9)) goto l_0x1014_c99b; /* jz 0x1014c99b */
            ii(0x1014_c992, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c995, 4); cmp(memb[ds, eax + 62], 0x1d);          /* cmp byte [eax+0x3e], 0x1d */
            ii(0x1014_c999, 2); if(jnz(0x1014_c99d, 2)) goto l_0x1014_c99d; /* jnz 0x1014c99d */
        l_0x1014_c99b:
            ii(0x1014_c99b, 2); jmp(0x1014_c9a6, 9); goto l_0x1014_c9a6; /* jmp 0x1014c9a6 */
        l_0x1014_c99d:
            ii(0x1014_c99d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c9a0, 4); cmp(memb[ds, eax + 62], 7);             /* cmp byte [eax+0x3e], 0x7 */
            ii(0x1014_c9a4, 2); if(jnz(0x1014_c9a8, 2)) goto l_0x1014_c9a8; /* jnz 0x1014c9a8 */
        l_0x1014_c9a6:
            ii(0x1014_c9a6, 2); jmp(0x1014_c9b1, 9); goto l_0x1014_c9b1; /* jmp 0x1014c9b1 */
        l_0x1014_c9a8:
            ii(0x1014_c9a8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c9ab, 4); cmp(memb[ds, eax + 62], 6);             /* cmp byte [eax+0x3e], 0x6 */
            ii(0x1014_c9af, 2); if(jnz(0x1014_c9b3, 2)) goto l_0x1014_c9b3; /* jnz 0x1014c9b3 */
        l_0x1014_c9b1:
            ii(0x1014_c9b1, 2); jmp(0x1014_c9bc, 9); goto l_0x1014_c9bc; /* jmp 0x1014c9bc */
        l_0x1014_c9b3:
            ii(0x1014_c9b3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c9b6, 4); cmp(memb[ds, eax + 62], 5);             /* cmp byte [eax+0x3e], 0x5 */
            ii(0x1014_c9ba, 2); if(jnz(0x1014_c9c3, 7)) goto l_0x1014_c9c3; /* jnz 0x1014c9c3 */
        l_0x1014_c9bc:
            ii(0x1014_c9bc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c9bf, 4); mov(memb[ds, eax + 62], 1);             /* mov byte [eax+0x3e], 0x1 */
        l_0x1014_c9c3:
            ii(0x1014_c9c3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c9c6, 5); call(0x1015_b336, 0xe96b);              /* call 0x1015b336 */
            ii(0x1014_c9cb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_c9ce, 5); call(0x1014_9cd1, -0x2d02);             /* call 0x10149cd1 */
            ii(0x1014_c9d3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_c9d5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_c9d6, 1); pop(edi);                               /* pop edi */
            ii(0x1014_c9d7, 1); pop(esi);                               /* pop esi */
            ii(0x1014_c9d8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_c9d9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_c9da, 1); ret();                                  /* ret */
        }
    }
}
