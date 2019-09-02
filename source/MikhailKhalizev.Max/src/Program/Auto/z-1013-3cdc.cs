using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_3cdc-7378b9a8")]
        public void Method_1013_3cdc()
        {
            ii(0x1013_3cdc, 5); push(0xb0);                             /* push 0xb0 */
            ii(0x1013_3ce1, 5); call(Definitions.sys_check_available_stack_size, 0x3_206c); /* call 0x10165d52 */
            ii(0x1013_3ce6, 1); push(ebx);                              /* push ebx */
            ii(0x1013_3ce7, 1); push(ecx);                              /* push ecx */
            ii(0x1013_3ce8, 1); push(edx);                              /* push edx */
            ii(0x1013_3ce9, 1); push(esi);                              /* push esi */
            ii(0x1013_3cea, 1); push(edi);                              /* push edi */
            ii(0x1013_3ceb, 1); push(ebp);                              /* push ebp */
            ii(0x1013_3cec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_3cee, 6); sub(esp, 0x94);                         /* sub esp, 0x94 */
            ii(0x1013_3cf4, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_3cf7, 5); mov(eax, 0x761);                        /* mov eax, 0x761 */
            ii(0x1013_3cfc, 5); call(Definitions.my_get_res_data_by_id_malloc, 0x4ea); /* call 0x101341eb */
            ii(0x1013_3d01, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1013_3d04, 4); cmp(memd[ss, ebp - 20], 0);             /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1013_3d08, 6); if(jz(0x1013_3fcf, 0x2c1)) goto l_0x1013_3fcf; /* jz 0x10133fcf */
            ii(0x1013_3d0e, 5); mov(eax, 0x761);                        /* mov eax, 0x761 */
            ii(0x1013_3d13, 5); call(0x1013_433e, 0x626);               /* call 0x1013433e */
            ii(0x1013_3d18, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1013_3d1b, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_3d1e, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_3d21, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
        l_0x1013_3d28:
            ii(0x1013_3d28, 4); cmp(memd[ss, ebp - 8], 0x5d);           /* cmp dword [ebp-0x8], 0x5d */
            ii(0x1013_3d2c, 6); if(jge(0x1013_3fc7, 0x295)) goto l_0x1013_3fc7; /* jge 0x10133fc7 */
            ii(0x1013_3d32, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
        l_0x1013_3d39:
            ii(0x1013_3d39, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1013_3d3c, 3); inc(memd[ss, ebp - 12]);                /* inc dword [ebp-0xc] */
            ii(0x1013_3d3f, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x1013_3d43, 2); mov(dl, memb[ds, edx]);                 /* mov dl, [edx] */
            ii(0x1013_3d45, 4); mov(memb[ds, eax + ebp - 124], dl);     /* mov [eax+ebp-0x7c], dl */
            ii(0x1013_3d49, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x1013_3d4d, 4); mov(al, memb[ds, eax + ebp - 124]);     /* mov al, [eax+ebp-0x7c] */
            ii(0x1013_3d51, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_3d56, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x1013_3d59, 2); if(jnz(0x1013_3d61, 6)) goto l_0x1013_3d61; /* jnz 0x10133d61 */
            ii(0x1013_3d5b, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1013_3d5e, 3); dec(memd[ss, ebp - 24]);                /* dec dword [ebp-0x18] */
        l_0x1013_3d61:
            ii(0x1013_3d61, 4); add(memd[ss, ebp - 16], -1 /* 0xff */); /* add dword [ebp-0x10], 0xffffffff */
            ii(0x1013_3d65, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1013_3d69, 2); if(jz(0x1013_3d80, 0x15)) goto l_0x1013_3d80; /* jz 0x10133d80 */
            ii(0x1013_3d6b, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1013_3d6e, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
            ii(0x1013_3d71, 1); cwde();                                 /* cwde */
            ii(0x1013_3d72, 4); mov(al, memb[ds, eax + ebp - 124]);     /* mov al, [eax+ebp-0x7c] */
            ii(0x1013_3d76, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_3d7b, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1013_3d7e, 2); if(jnz(0x1013_3d82, 2)) goto l_0x1013_3d82; /* jnz 0x10133d82 */
        l_0x1013_3d80:
            ii(0x1013_3d80, 2); jmp(0x1013_3d84, 2); goto l_0x1013_3d84; /* jmp 0x10133d84 */
        l_0x1013_3d82:
            ii(0x1013_3d82, 2); jmp(0x1013_3d39, -0x4b); goto l_0x1013_3d39; /* jmp 0x10133d39 */
        l_0x1013_3d84:
            ii(0x1013_3d84, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x1013_3d88, 5); mov(memb[ds, eax + ebp - 124], 0);      /* mov byte [eax+ebp-0x7c], 0x0 */
            ii(0x1013_3d8d, 4); cmp(memb[ss, ebp - 124], 0x3b);         /* cmp byte [ebp-0x7c], 0x3b */
            ii(0x1013_3d91, 2); if(jz(0x1013_3d9d, 0xa)) goto l_0x1013_3d9d; /* jz 0x10133d9d */
            ii(0x1013_3d93, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_3d95, 3); mov(al, memb[ss, ebp - 124]);           /* mov al, [ebp-0x7c] */
            ii(0x1013_3d98, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1013_3d9b, 2); if(jnz(0x1013_3da2, 5)) goto l_0x1013_3da2; /* jnz 0x10133da2 */
        l_0x1013_3d9d:
            ii(0x1013_3d9d, 5); jmp(0x1013_3fc2, 0x220); goto l_0x1013_3fc2; /* jmp 0x10133fc2 */
        l_0x1013_3da2:
            ii(0x1013_3da2, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x1013_3da7, 5); call(Definitions.sys_new, 0x3_2054);    /* call 0x10165e00 */
            ii(0x1013_3dac, 3); mov(memd[ss, ebp - 128], eax);          /* mov [ebp-0x80], eax */
            ii(0x1013_3daf, 3); mov(eax, memd[ss, ebp - 128]);          /* mov eax, [ebp-0x80] */
            ii(0x1013_3db2, 6); mov(memd[ss, ebp - 132], eax);          /* mov [ebp-0x84], eax */
            ii(0x1013_3db8, 7); cmp(memd[ss, ebp - 132], 0);            /* cmp dword [ebp-0x84], 0x0 */
            ii(0x1013_3dbf, 2); if(jz(0x1013_3ddd, 0x1c)) goto l_0x1013_3ddd; /* jz 0x10133ddd */
            ii(0x1013_3dc1, 3); mov(eax, memd[ss, ebp - 128]);          /* mov eax, [ebp-0x80] */
            ii(0x1013_3dc4, 5); call(0x1016_3505, 0x2_f73c);            /* call 0x10163505 */
            ii(0x1013_3dc9, 6); mov(memd[ss, ebp - 136], eax);          /* mov [ebp-0x88], eax */
            ii(0x1013_3dcf, 6); mov(eax, memd[ss, ebp - 136]);          /* mov eax, [ebp-0x88] */
            ii(0x1013_3dd5, 6); mov(memd[ss, ebp - 140], eax);          /* mov [ebp-0x8c], eax */
            ii(0x1013_3ddb, 2); jmp(0x1013_3de9, 0xc); goto l_0x1013_3de9; /* jmp 0x10133de9 */
        l_0x1013_3ddd:
            ii(0x1013_3ddd, 6); mov(eax, memd[ss, ebp - 132]);          /* mov eax, [ebp-0x84] */
            ii(0x1013_3de3, 6); mov(memd[ss, ebp - 140], eax);          /* mov [ebp-0x8c], eax */
        l_0x1013_3de9:
            ii(0x1013_3de9, 6); mov(edx, memd[ss, ebp - 140]);          /* mov edx, [ebp-0x8c] */
            ii(0x1013_3def, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3df5, 5); call(0x1007_6800, -0xb_d5fa);           /* call 0x10076800 */
            ii(0x1013_3dfa, 10); mov(memd[ss, ebp - 148], 0);           /* mov dword [ebp-0x94], 0x0 */
            ii(0x1013_3e04, 6); lea(edx, memd[ss, ebp - 148]);          /* lea edx, [ebp-0x94] */
            ii(0x1013_3e0a, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1013_3e0d, 5); call(0x1013_3c5b, -0x1b7);              /* call 0x10133c5b */
            ii(0x1013_3e12, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3e14, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3e1a, 5); call(0x1007_6730, -0xb_d6ef);           /* call 0x10076730 */
            ii(0x1013_3e1f, 4); mov(memw[ds, eax + 8], dx);             /* mov [eax+0x8], dx */
            ii(0x1013_3e23, 6); lea(edx, memd[ss, ebp - 148]);          /* lea edx, [ebp-0x94] */
            ii(0x1013_3e29, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1013_3e2c, 5); call(0x1013_3c5b, -0x1d6);              /* call 0x10133c5b */
            ii(0x1013_3e31, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3e33, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3e39, 5); call(0x1007_6730, -0xb_d70e);           /* call 0x10076730 */
            ii(0x1013_3e3e, 4); mov(memw[ds, eax + 10], dx);            /* mov [eax+0xa], dx */
            ii(0x1013_3e42, 6); lea(edx, memd[ss, ebp - 148]);          /* lea edx, [ebp-0x94] */
            ii(0x1013_3e48, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1013_3e4b, 5); call(0x1013_3c5b, -0x1f5);              /* call 0x10133c5b */
            ii(0x1013_3e50, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3e52, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3e58, 5); call(0x1007_6730, -0xb_d72d);           /* call 0x10076730 */
            ii(0x1013_3e5d, 4); mov(memw[ds, eax + 12], dx);            /* mov [eax+0xc], dx */
            ii(0x1013_3e61, 6); lea(edx, memd[ss, ebp - 148]);          /* lea edx, [ebp-0x94] */
            ii(0x1013_3e67, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1013_3e6a, 5); call(0x1013_3c5b, -0x214);              /* call 0x10133c5b */
            ii(0x1013_3e6f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3e71, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3e77, 5); call(0x1007_6730, -0xb_d74c);           /* call 0x10076730 */
            ii(0x1013_3e7c, 4); mov(memw[ds, eax + 14], dx);            /* mov [eax+0xe], dx */
            ii(0x1013_3e80, 6); lea(edx, memd[ss, ebp - 148]);          /* lea edx, [ebp-0x94] */
            ii(0x1013_3e86, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1013_3e89, 5); call(0x1013_3c5b, -0x233);              /* call 0x10133c5b */
            ii(0x1013_3e8e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3e90, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3e96, 5); call(0x1007_6730, -0xb_d76b);           /* call 0x10076730 */
            ii(0x1013_3e9b, 3); mov(memb[ds, eax + 22], dl);            /* mov [eax+0x16], dl */
            ii(0x1013_3e9e, 6); lea(edx, memd[ss, ebp - 148]);          /* lea edx, [ebp-0x94] */
            ii(0x1013_3ea4, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1013_3ea7, 5); call(0x1013_3c5b, -0x251);              /* call 0x10133c5b */
            ii(0x1013_3eac, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3eae, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3eb4, 5); call(0x1007_6730, -0xb_d789);           /* call 0x10076730 */
            ii(0x1013_3eb9, 4); mov(memw[ds, eax + 16], dx);            /* mov [eax+0x10], dx */
            ii(0x1013_3ebd, 6); lea(edx, memd[ss, ebp - 148]);          /* lea edx, [ebp-0x94] */
            ii(0x1013_3ec3, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1013_3ec6, 5); call(0x1013_3c5b, -0x270);              /* call 0x10133c5b */
            ii(0x1013_3ecb, 6); lea(edx, memd[ss, ebp - 148]);          /* lea edx, [ebp-0x94] */
            ii(0x1013_3ed1, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1013_3ed4, 5); call(0x1013_3c5b, -0x27e);              /* call 0x10133c5b */
            ii(0x1013_3ed9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3edb, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3ee1, 5); call(0x1007_6730, -0xb_d7b6);           /* call 0x10076730 */
            ii(0x1013_3ee6, 4); mov(memw[ds, eax + 18], dx);            /* mov [eax+0x12], dx */
            ii(0x1013_3eea, 6); lea(edx, memd[ss, ebp - 148]);          /* lea edx, [ebp-0x94] */
            ii(0x1013_3ef0, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1013_3ef3, 5); call(0x1013_3c5b, -0x29d);              /* call 0x10133c5b */
            ii(0x1013_3ef8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3efa, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3f00, 5); call(0x1007_6730, -0xb_d7d5);           /* call 0x10076730 */
            ii(0x1013_3f05, 4); mov(memw[ds, eax + 20], dx);            /* mov [eax+0x14], dx */
            ii(0x1013_3f09, 6); lea(edx, memd[ss, ebp - 148]);          /* lea edx, [ebp-0x94] */
            ii(0x1013_3f0f, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1013_3f12, 5); call(0x1013_3c5b, -0x2bc);              /* call 0x10133c5b */
            ii(0x1013_3f17, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3f19, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3f1f, 5); call(0x1007_6730, -0xb_d7f4);           /* call 0x10076730 */
            ii(0x1013_3f24, 4); mov(memw[ds, eax + 23], dx);            /* mov [eax+0x17], dx */
            ii(0x1013_3f28, 6); lea(edx, memd[ss, ebp - 148]);          /* lea edx, [ebp-0x94] */
            ii(0x1013_3f2e, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1013_3f31, 5); call(0x1013_3c5b, -0x2db);              /* call 0x10133c5b */
            ii(0x1013_3f36, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3f38, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3f3e, 5); call(0x1007_6730, -0xb_d813);           /* call 0x10076730 */
            ii(0x1013_3f43, 4); mov(memw[ds, eax + 25], dx);            /* mov [eax+0x19], dx */
            ii(0x1013_3f47, 6); lea(edx, memd[ss, ebp - 148]);          /* lea edx, [ebp-0x94] */
            ii(0x1013_3f4d, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1013_3f50, 5); call(0x1013_3c5b, -0x2fa);              /* call 0x10133c5b */
            ii(0x1013_3f55, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3f57, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3f5d, 5); call(0x1007_6730, -0xb_d832);           /* call 0x10076730 */
            ii(0x1013_3f62, 4); mov(memw[ds, eax + 27], dx);            /* mov [eax+0x1b], dx */
            ii(0x1013_3f66, 6); lea(edx, memd[ss, ebp - 148]);          /* lea edx, [ebp-0x94] */
            ii(0x1013_3f6c, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1013_3f6f, 5); call(0x1013_3c5b, -0x319);              /* call 0x10133c5b */
            ii(0x1013_3f74, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3f76, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3f7c, 5); call(0x1007_6730, -0xb_d851);           /* call 0x10076730 */
            ii(0x1013_3f81, 4); mov(memw[ds, eax + 29], dx);            /* mov [eax+0x1d], dx */
            ii(0x1013_3f85, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3f8b, 5); call(0x1007_6730, -0xb_d860);           /* call 0x10076730 */
            ii(0x1013_3f90, 6); mov(memw[ds, eax + 31], 0);             /* mov word [eax+0x1f], 0x0 */
            ii(0x1013_3f96, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3f9c, 5); call(0x1007_678c, -0xb_d815);           /* call 0x1007678c */
            ii(0x1013_3fa1, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_3fa3, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1013_3fa7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_3faa, 5); call(0x1013_6564, 0x25b5);              /* call 0x10136564 */
            ii(0x1013_3faf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_3fb2, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1013_3fb5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_3fb7, 6); lea(eax, memd[ss, ebp - 144]);          /* lea eax, [ebp-0x90] */
            ii(0x1013_3fbd, 5); call(0x1007_5eec, -0xb_e0d6);           /* call 0x10075eec */
        l_0x1013_3fc2:
            ii(0x1013_3fc2, 5); jmp(0x1013_3d28, -0x29f); goto l_0x1013_3d28; /* jmp 0x10133d28 */
        l_0x1013_3fc7:
            ii(0x1013_3fc7, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1013_3fca, 5); call(Definitions.sys_delete, 0x3_1f95); /* call 0x10165f64 */
        l_0x1013_3fcf:
            ii(0x1013_3fcf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_3fd1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_3fd2, 1); pop(edi);                               /* pop edi */
            ii(0x1013_3fd3, 1); pop(esi);                               /* pop esi */
            ii(0x1013_3fd4, 1); pop(edx);                               /* pop edx */
            ii(0x1013_3fd5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_3fd6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_3fd7, 1); ret();                                  /* ret */
        }
    }
}
