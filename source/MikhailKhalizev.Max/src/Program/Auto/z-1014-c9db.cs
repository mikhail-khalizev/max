using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_c9db-6248ef48")]
        public void Method_1014_c9db()
        {
            ii(0x1014_c9db, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_c9e0, 5); calld(Definitions.sys_check_available_stack_size, 0x1_936d); /* call 0x10165d52 */
            ii(0x1014_c9e5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_c9e6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_c9e7, 1); pushd(esi);                             /* push esi */
            ii(0x1014_c9e8, 1); pushd(edi);                             /* push edi */
            ii(0x1014_c9e9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_c9ea, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_c9ec, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_c9f2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_c9f5, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_c9f8, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1014_c9fd, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_ca00, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x1014_ca03, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ca06, 5); calld(0x1013_c055, -0x1_09b6);          /* call 0x1013c055 */
            ii(0x1014_ca0b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ca0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ca10, 4); mov(dx, memw_a32[ds, eax + 0x7c]);      /* mov dx, [eax+0x7c] */
            ii(0x1014_ca14, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ca17, 5); calld(0x1013_c12f, -0x1_08ed);          /* call 0x1013c12f */
            ii(0x1014_ca1c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ca1f, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x1014_ca22, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ca25, 5); calld(0x1013_c164, -0x1_08c6);          /* call 0x1013c164 */
            ii(0x1014_ca2a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ca2d, 3); mov(edx, memd_a32[ds, eax + 0x14]);     /* mov edx, [eax+0x14] */
            ii(0x1014_ca30, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_ca33, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ca36, 5); calld(0x1013_c0fa, -0x1_0941);          /* call 0x1013c0fa */
            ii(0x1014_ca3b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ca3e, 3); mov(edx, memd_a32[ds, eax + 0x16]);     /* mov edx, [eax+0x16] */
            ii(0x1014_ca41, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_ca44, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ca47, 5); calld(0x1013_c0fa, -0x1_0952);          /* call 0x1013c0fa */
            ii(0x1014_ca4c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ca4f, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1014_ca52, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_ca55, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ca58, 5); calld(0x1013_c0fa, -0x1_0963);          /* call 0x1013c0fa */
            ii(0x1014_ca5d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ca60, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1014_ca63, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_ca66, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ca69, 5); calld(0x1013_c0fa, -0x1_0974);          /* call 0x1013c0fa */
            ii(0x1014_ca6e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ca71, 7); cmp(memd_a32[ds, eax + 0xa7], 0);       /* cmp dword [eax+0xa7], 0x0 */
            ii(0x1014_ca78, 2); if(jnzd(0x1014_ca8f, 0x15)) goto l_0x1014_ca8f; /* jnz 0x1014ca8f */
            ii(0x1014_ca7a, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_ca81, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1014_ca85, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ca88, 5); calld(0x1013_c0fa, -0x1_0993);          /* call 0x1013c0fa */
            ii(0x1014_ca8d, 2); jmpd(0x1014_cac1, 0x32); goto l_0x1014_cac1; /* jmp 0x1014cac1 */
        l_0x1014_ca8f:
            ii(0x1014_ca8f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ca92, 6); mov(eax, memd_a32[ds, eax + 0xa7]);     /* mov eax, [eax+0xa7] */
            ii(0x1014_ca98, 5); calld(Definitions.sys_strlen, 0x2_542a); /* call 0x10171ec7 */
            ii(0x1014_ca9d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_caa0, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1014_caa4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_caa7, 5); calld(0x1013_c0fa, -0x1_09b2);          /* call 0x1013c0fa */
            ii(0x1014_caac, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1014_cab0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cab3, 6); mov(edx, memd_a32[ds, eax + 0xa7]);     /* mov edx, [eax+0xa7] */
            ii(0x1014_cab9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cabc, 5); calld(0x1013_c055, -0x1_0a6c);          /* call 0x1013c055 */
        l_0x1014_cac1:
            ii(0x1014_cac1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cac4, 6); mov(edx, memd_a32[ds, eax + 0xd7]);     /* mov edx, [eax+0xd7] */
            ii(0x1014_caca, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_cacd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cad0, 5); calld(0x1013_c0fa, -0x1_09db);          /* call 0x1013c0fa */
            ii(0x1014_cad5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cad8, 6); mov(edx, memd_a32[ds, edx + 0xd9]);     /* mov edx, [edx+0xd9] */
            ii(0x1014_cade, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_cae1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cae4, 5); calld(0x1013_c0fa, -0x1_09ef);          /* call 0x1013c0fa */
            ii(0x1014_cae9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_caec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_caee, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1014_caf1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_caf4, 5); calld(0x1013_c0c5, -0x1_0a34);          /* call 0x1013c0c5 */
            ii(0x1014_caf9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cafc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cafe, 3); mov(dl, memb_a32[ds, eax + 0x27]);      /* mov dl, [eax+0x27] */
            ii(0x1014_cb01, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cb04, 5); calld(0x1013_c0c5, -0x1_0a44);          /* call 0x1013c0c5 */
            ii(0x1014_cb09, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cb0c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cb0e, 3); mov(dl, memb_a32[ds, eax + 0x28]);      /* mov dl, [eax+0x28] */
            ii(0x1014_cb11, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cb14, 5); calld(0x1013_c0c5, -0x1_0a54);          /* call 0x1013c0c5 */
            ii(0x1014_cb19, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cb1c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cb1e, 3); mov(dl, memb_a32[ds, eax + 0x29]);      /* mov dl, [eax+0x29] */
            ii(0x1014_cb21, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cb24, 5); calld(0x1013_c0c5, -0x1_0a64);          /* call 0x1013c0c5 */
            ii(0x1014_cb29, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1014_cb2e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cb31, 6); add(edx, 0xab);                         /* add edx, 0xab */
            ii(0x1014_cb37, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cb3a, 5); calld(0x1013_c055, -0x1_0aea);          /* call 0x1013c055 */
            ii(0x1014_cb3f, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1014_cb44, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cb47, 6); add(edx, 0xb0);                         /* add edx, 0xb0 */
            ii(0x1014_cb4d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cb50, 5); calld(0x1013_c055, -0x1_0b00);          /* call 0x1013c055 */
            ii(0x1014_cb55, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cb58, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cb5a, 3); mov(dl, memb_a32[ds, eax + 0x2a]);      /* mov dl, [eax+0x2a] */
            ii(0x1014_cb5d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cb60, 5); calld(0x1013_c0c5, -0x1_0aa0);          /* call 0x1013c0c5 */
            ii(0x1014_cb65, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cb68, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cb6a, 3); mov(dl, memb_a32[ds, eax + 0x2b]);      /* mov dl, [eax+0x2b] */
            ii(0x1014_cb6d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cb70, 5); calld(0x1013_c0c5, -0x1_0ab0);          /* call 0x1013c0c5 */
            ii(0x1014_cb75, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cb78, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cb7a, 3); mov(dl, memb_a32[ds, eax + 0x2c]);      /* mov dl, [eax+0x2c] */
            ii(0x1014_cb7d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cb80, 5); calld(0x1013_c0c5, -0x1_0ac0);          /* call 0x1013c0c5 */
            ii(0x1014_cb85, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cb88, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cb8a, 3); mov(dl, memb_a32[ds, eax + 0x2d]);      /* mov dl, [eax+0x2d] */
            ii(0x1014_cb8d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cb90, 5); calld(0x1013_c0c5, -0x1_0ad0);          /* call 0x1013c0c5 */
            ii(0x1014_cb95, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x1014_cb9a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cb9d, 6); add(edx, 0xb5);                         /* add edx, 0xb5 */
            ii(0x1014_cba3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cba6, 5); calld(0x1013_c055, -0x1_0b56);          /* call 0x1013c055 */
            ii(0x1014_cbab, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x1014_cbb0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cbb3, 6); add(edx, 0xc5);                         /* add edx, 0xc5 */
            ii(0x1014_cbb9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cbbc, 5); calld(0x1013_c055, -0x1_0b6c);          /* call 0x1013c055 */
            ii(0x1014_cbc1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cbc4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cbc6, 3); mov(dl, memb_a32[ds, eax + 0x2e]);      /* mov dl, [eax+0x2e] */
            ii(0x1014_cbc9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cbcc, 5); calld(0x1013_c0c5, -0x1_0b0c);          /* call 0x1013c0c5 */
            ii(0x1014_cbd1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cbd4, 3); mov(edx, memd_a32[ds, edx + 0x2c]);     /* mov edx, [edx+0x2c] */
            ii(0x1014_cbd7, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1014_cbda, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cbdd, 5); calld(0x1013_c090, -0x1_0b52);          /* call 0x1013c090 */
            ii(0x1014_cbe2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cbe5, 3); mov(edx, memd_a32[ds, edx + 0x2d]);     /* mov edx, [edx+0x2d] */
            ii(0x1014_cbe8, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1014_cbeb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cbee, 5); calld(0x1013_c090, -0x1_0b63);          /* call 0x1013c090 */
            ii(0x1014_cbf3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cbf6, 3); mov(edx, memd_a32[ds, edx + 0x2f]);     /* mov edx, [edx+0x2f] */
            ii(0x1014_cbf9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_cbfc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cbff, 5); calld(0x1013_c0fa, -0x1_0b0a);          /* call 0x1013c0fa */
            ii(0x1014_cc04, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cc07, 3); mov(edx, memd_a32[ds, edx + 0x31]);     /* mov edx, [edx+0x31] */
            ii(0x1014_cc0a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_cc0d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cc10, 5); calld(0x1013_c0fa, -0x1_0b1b);          /* call 0x1013c0fa */
            ii(0x1014_cc15, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cc18, 3); mov(edx, memd_a32[ds, edx + 0x33]);     /* mov edx, [edx+0x33] */
            ii(0x1014_cc1b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_cc1e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cc21, 5); calld(0x1013_c0fa, -0x1_0b2c);          /* call 0x1013c0fa */
            ii(0x1014_cc26, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cc29, 3); mov(edx, memd_a32[ds, edx + 0x35]);     /* mov edx, [edx+0x35] */
            ii(0x1014_cc2c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_cc2f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cc32, 5); calld(0x1013_c0fa, -0x1_0b3d);          /* call 0x1013c0fa */
            ii(0x1014_cc37, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cc3a, 3); mov(edx, memd_a32[ds, edx + 0x37]);     /* mov edx, [edx+0x37] */
            ii(0x1014_cc3d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_cc40, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cc43, 5); calld(0x1013_c0fa, -0x1_0b4e);          /* call 0x1013c0fa */
            ii(0x1014_cc48, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cc4b, 6); mov(edx, memd_a32[ds, edx + 0xd3]);     /* mov edx, [edx+0xd3] */
            ii(0x1014_cc51, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_cc54, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cc57, 5); calld(0x1013_c0fa, -0x1_0b62);          /* call 0x1013c0fa */
            ii(0x1014_cc5c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cc5f, 6); mov(edx, memd_a32[ds, edx + 0xd5]);     /* mov edx, [edx+0xd5] */
            ii(0x1014_cc65, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_cc68, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cc6b, 5); calld(0x1013_c0fa, -0x1_0b76);          /* call 0x1013c0fa */
            ii(0x1014_cc70, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cc73, 3); mov(edx, memd_a32[ds, edx + 0x39]);     /* mov edx, [edx+0x39] */
            ii(0x1014_cc76, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_cc79, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cc7c, 5); calld(0x1013_c0fa, -0x1_0b87);          /* call 0x1013c0fa */
            ii(0x1014_cc81, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_cc86, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cc89, 3); add(edx, 0x3d);                         /* add edx, 0x3d */
            ii(0x1014_cc8c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cc8f, 5); calld(0x1013_c055, -0x1_0c3f);          /* call 0x1013c055 */
            ii(0x1014_cc94, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_cc99, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cc9c, 3); add(edx, 0x3e);                         /* add edx, 0x3e */
            ii(0x1014_cc9f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cca2, 5); calld(0x1013_c055, -0x1_0c52);          /* call 0x1013c055 */
            ii(0x1014_cca7, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_ccac, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_ccaf, 3); add(edx, 0x3f);                         /* add edx, 0x3f */
            ii(0x1014_ccb2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ccb5, 5); calld(0x1013_c055, -0x1_0c65);          /* call 0x1013c055 */
            ii(0x1014_ccba, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_ccbf, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_ccc2, 3); add(edx, 0x40);                         /* add edx, 0x40 */
            ii(0x1014_ccc5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ccc8, 5); calld(0x1013_c055, -0x1_0c78);          /* call 0x1013c055 */
            ii(0x1014_cccd, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_ccd2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_ccd5, 6); add(edx, 0xa6);                         /* add edx, 0xa6 */
            ii(0x1014_ccdb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ccde, 5); calld(0x1013_c055, -0x1_0c8e);          /* call 0x1013c055 */
            ii(0x1014_cce3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cce6, 3); mov(edx, memd_a32[ds, edx + 0x3f]);     /* mov edx, [edx+0x3f] */
            ii(0x1014_cce9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_ccec, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ccef, 5); calld(0x1013_c0fa, -0x1_0bfa);          /* call 0x1013c0fa */
            ii(0x1014_ccf4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_ccf7, 3); mov(edx, memd_a32[ds, edx + 0x41]);     /* mov edx, [edx+0x41] */
            ii(0x1014_ccfa, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_ccfd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cd00, 5); calld(0x1013_c0fa, -0x1_0c0b);          /* call 0x1013c0fa */
            ii(0x1014_cd05, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cd08, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cd0a, 3); mov(dl, memb_a32[ds, eax + 0x45]);      /* mov dl, [eax+0x45] */
            ii(0x1014_cd0d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cd10, 5); calld(0x1013_c0c5, -0x1_0c50);          /* call 0x1013c0c5 */
            ii(0x1014_cd15, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cd18, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cd1a, 3); mov(dl, memb_a32[ds, eax + 0x46]);      /* mov dl, [eax+0x46] */
            ii(0x1014_cd1d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cd20, 5); calld(0x1013_c0c5, -0x1_0c60);          /* call 0x1013c0c5 */
            ii(0x1014_cd25, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cd28, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cd2a, 3); mov(dl, memb_a32[ds, eax + 0x47]);      /* mov dl, [eax+0x47] */
            ii(0x1014_cd2d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cd30, 5); calld(0x1013_c0c5, -0x1_0c70);          /* call 0x1013c0c5 */
            ii(0x1014_cd35, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cd38, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cd3a, 3); mov(dl, memb_a32[ds, eax + 0x48]);      /* mov dl, [eax+0x48] */
            ii(0x1014_cd3d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cd40, 5); calld(0x1013_c0c5, -0x1_0c80);          /* call 0x1013c0c5 */
            ii(0x1014_cd45, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cd48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cd4a, 3); mov(dl, memb_a32[ds, eax + 0x49]);      /* mov dl, [eax+0x49] */
            ii(0x1014_cd4d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cd50, 5); calld(0x1013_c0c5, -0x1_0c90);          /* call 0x1013c0c5 */
            ii(0x1014_cd55, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cd58, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cd5a, 3); mov(dl, memb_a32[ds, eax + 0x4a]);      /* mov dl, [eax+0x4a] */
            ii(0x1014_cd5d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cd60, 5); calld(0x1013_c0c5, -0x1_0ca0);          /* call 0x1013c0c5 */
            ii(0x1014_cd65, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cd68, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cd6a, 3); mov(dl, memb_a32[ds, eax + 0x4b]);      /* mov dl, [eax+0x4b] */
            ii(0x1014_cd6d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cd70, 5); calld(0x1013_c0c5, -0x1_0cb0);          /* call 0x1013c0c5 */
            ii(0x1014_cd75, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cd78, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cd7a, 3); mov(dl, memb_a32[ds, eax + 0x4c]);      /* mov dl, [eax+0x4c] */
            ii(0x1014_cd7d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cd80, 5); calld(0x1013_c0c5, -0x1_0cc0);          /* call 0x1013c0c5 */
            ii(0x1014_cd85, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cd88, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cd8a, 3); mov(dl, memb_a32[ds, eax + 0x4d]);      /* mov dl, [eax+0x4d] */
            ii(0x1014_cd8d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cd90, 5); calld(0x1013_c0c5, -0x1_0cd0);          /* call 0x1013c0c5 */
            ii(0x1014_cd95, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cd98, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cd9a, 3); mov(dl, memb_a32[ds, eax + 0x4e]);      /* mov dl, [eax+0x4e] */
            ii(0x1014_cd9d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cda0, 5); calld(0x1013_c0c5, -0x1_0ce0);          /* call 0x1013c0c5 */
            ii(0x1014_cda5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cda8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cdaa, 3); mov(dl, memb_a32[ds, eax + 0x50]);      /* mov dl, [eax+0x50] */
            ii(0x1014_cdad, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cdb0, 5); calld(0x1013_c0c5, -0x1_0cf0);          /* call 0x1013c0c5 */
            ii(0x1014_cdb5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cdb8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cdba, 3); mov(dl, memb_a32[ds, eax + 0x51]);      /* mov dl, [eax+0x51] */
            ii(0x1014_cdbd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cdc0, 5); calld(0x100c_b818, -0x8_15ad);          /* call 0x100cb818 */
            ii(0x1014_cdc5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cdc8, 3); mov(edx, memd_a32[ds, edx + 0x50]);     /* mov edx, [edx+0x50] */
            ii(0x1014_cdcb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_cdce, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cdd1, 5); calld(0x1013_c0fa, -0x1_0cdc);          /* call 0x1013c0fa */
            ii(0x1014_cdd6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cdd9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cddb, 3); mov(dl, memb_a32[ds, eax + 0x54]);      /* mov dl, [eax+0x54] */
            ii(0x1014_cdde, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cde1, 5); calld(0x1013_c0c5, -0x1_0d21);          /* call 0x1013c0c5 */
            ii(0x1014_cde6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cde9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cdeb, 3); mov(dl, memb_a32[ds, eax + 0x55]);      /* mov dl, [eax+0x55] */
            ii(0x1014_cdee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cdf1, 5); calld(0x100c_b818, -0x8_15de);          /* call 0x100cb818 */
            ii(0x1014_cdf6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cdf9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cdfb, 3); mov(dl, memb_a32[ds, eax + 0x56]);      /* mov dl, [eax+0x56] */
            ii(0x1014_cdfe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ce01, 5); calld(0x100c_b818, -0x8_15ee);          /* call 0x100cb818 */
            ii(0x1014_ce06, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_ce0b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_ce0e, 3); add(edx, 0x57);                         /* add edx, 0x57 */
            ii(0x1014_ce11, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ce14, 5); calld(0x1013_c055, -0x1_0dc4);          /* call 0x1013c055 */
            ii(0x1014_ce19, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ce1c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ce1e, 3); mov(dl, memb_a32[ds, eax + 0x58]);      /* mov dl, [eax+0x58] */
            ii(0x1014_ce21, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ce24, 5); calld(0x1013_c0c5, -0x1_0d64);          /* call 0x1013c0c5 */
            ii(0x1014_ce29, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ce2c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ce2e, 3); mov(dl, memb_a32[ds, eax + 0x59]);      /* mov dl, [eax+0x59] */
            ii(0x1014_ce31, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ce34, 5); calld(0x100c_b818, -0x8_1621);          /* call 0x100cb818 */
            ii(0x1014_ce39, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ce3c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ce3e, 3); mov(dl, memb_a32[ds, eax + 0x5a]);      /* mov dl, [eax+0x5a] */
            ii(0x1014_ce41, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ce44, 5); calld(0x100c_b818, -0x8_1631);          /* call 0x100cb818 */
            ii(0x1014_ce49, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1014_ce4e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_ce51, 3); add(edx, 0x5d);                         /* add edx, 0x5d */
            ii(0x1014_ce54, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ce57, 5); calld(0x1013_c055, -0x1_0e07);          /* call 0x1013c055 */
            ii(0x1014_ce5c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ce5f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ce61, 3); mov(dl, memb_a32[ds, eax + 0x5e]);      /* mov dl, [eax+0x5e] */
            ii(0x1014_ce64, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ce67, 5); calld(0x1013_c0c5, -0x1_0da7);          /* call 0x1013c0c5 */
            ii(0x1014_ce6c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ce6f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ce71, 3); mov(dl, memb_a32[ds, eax + 0x5f]);      /* mov dl, [eax+0x5f] */
            ii(0x1014_ce74, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ce77, 5); calld(0x1013_c0c5, -0x1_0db7);          /* call 0x1013c0c5 */
            ii(0x1014_ce7c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ce7f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ce81, 3); mov(dl, memb_a32[ds, eax + 0x6b]);      /* mov dl, [eax+0x6b] */
            ii(0x1014_ce84, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ce87, 5); calld(0x1013_c0c5, -0x1_0dc7);          /* call 0x1013c0c5 */
            ii(0x1014_ce8c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ce8f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ce91, 3); mov(dl, memb_a32[ds, eax + 0x60]);      /* mov dl, [eax+0x60] */
            ii(0x1014_ce94, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ce97, 5); calld(0x1013_c0c5, -0x1_0dd7);          /* call 0x1013c0c5 */
            ii(0x1014_ce9c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ce9f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cea1, 3); mov(dl, memb_a32[ds, eax + 0x61]);      /* mov dl, [eax+0x61] */
            ii(0x1014_cea4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cea7, 5); calld(0x1013_c0c5, -0x1_0de7);          /* call 0x1013c0c5 */
            ii(0x1014_ceac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ceaf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ceb1, 3); mov(dl, memb_a32[ds, eax + 0x62]);      /* mov dl, [eax+0x62] */
            ii(0x1014_ceb4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ceb7, 5); calld(0x1013_c0c5, -0x1_0df7);          /* call 0x1013c0c5 */
            ii(0x1014_cebc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cebf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cec1, 3); mov(dl, memb_a32[ds, eax + 0x63]);      /* mov dl, [eax+0x63] */
            ii(0x1014_cec4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cec7, 5); calld(0x1013_c0c5, -0x1_0e07);          /* call 0x1013c0c5 */
            ii(0x1014_cecc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cecf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ced1, 3); mov(dl, memb_a32[ds, eax + 0x64]);      /* mov dl, [eax+0x64] */
            ii(0x1014_ced4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ced7, 5); calld(0x1013_c0c5, -0x1_0e17);          /* call 0x1013c0c5 */
            ii(0x1014_cedc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cedf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cee1, 3); mov(dl, memb_a32[ds, eax + 0x7b]);      /* mov dl, [eax+0x7b] */
            ii(0x1014_cee4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cee7, 5); calld(0x100c_b818, -0x8_16d4);          /* call 0x100cb818 */
            ii(0x1014_ceec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ceef, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cef1, 3); mov(dl, memb_a32[ds, eax + 0x7a]);      /* mov dl, [eax+0x7a] */
            ii(0x1014_cef4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cef7, 5); calld(0x100c_b818, -0x8_16e4);          /* call 0x100cb818 */
            ii(0x1014_cefc, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_ceff, 3); mov(edx, memd_a32[ds, edx + 0x76]);     /* mov edx, [edx+0x76] */
            ii(0x1014_cf02, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_cf05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cf08, 5); calld(0x1013_c0fa, -0x1_0e13);          /* call 0x1013c0fa */
            ii(0x1014_cf0d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cf10, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cf12, 3); mov(dl, memb_a32[ds, eax + 0x5b]);      /* mov dl, [eax+0x5b] */
            ii(0x1014_cf15, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cf18, 5); calld(0x100c_b818, -0x8_1705);          /* call 0x100cb818 */
            ii(0x1014_cf1d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cf20, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_cf22, 3); mov(dl, memb_a32[ds, eax + 0x5c]);      /* mov dl, [eax+0x5c] */
            ii(0x1014_cf25, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cf28, 5); calld(0x100c_b818, -0x8_1715);          /* call 0x100cb818 */
            ii(0x1014_cf2d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cf30, 6); mov(edx, memd_a32[ds, edx + 0xdd]);     /* mov edx, [edx+0xdd] */
            ii(0x1014_cf36, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cf39, 5); calld(0x1013_c164, -0x1_0dda);          /* call 0x1013c164 */
            ii(0x1014_cf3e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cf41, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_cf44, 5); calld(0x1015_53e0, 0x8497);             /* call 0x101553e0 */
            ii(0x1014_cf49, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1014_cf4c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_cf4e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_cf50, 5); calld(0x1013_c25c, -0x1_0cf9);          /* call 0x1013c25c */
            ii(0x1014_cf55, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_cf58, 3); mov(edx, memd_a32[ds, edx + 0x67]);     /* mov edx, [edx+0x67] */
            ii(0x1014_cf5b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_cf5e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cf61, 5); calld(0x1013_c0fa, -0x1_0e6c);          /* call 0x1013c0fa */
            ii(0x1014_cf66, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cf69, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1014_cf6c, 5); calld(0x1007_678c, -0xd_67e5);          /* call 0x1007678c */
            ii(0x1014_cf71, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_cf73, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cf76, 5); calld(0x1013_c25c, -0x1_0d1f);          /* call 0x1013c25c */
            ii(0x1014_cf7b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cf7e, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_cf81, 5); calld(0x1007_68e0, -0xd_66a6);          /* call 0x100768e0 */
            ii(0x1014_cf86, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1014_cf89, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_cf8b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_cf8d, 5); calld(0x1013_c25c, -0x1_0d36);          /* call 0x1013c25c */
            ii(0x1014_cf92, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cf95, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1014_cf9a, 5); calld(0x1007_6600, -0xd_699f);          /* call 0x10076600 */
            ii(0x1014_cf9f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_cfa1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cfa4, 5); calld(0x1013_c25c, -0x1_0d4d);          /* call 0x1013c25c */
            ii(0x1014_cfa9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cfac, 5); add(eax, 0x86);                         /* add eax, 0x86 */
            ii(0x1014_cfb1, 5); calld(0x1007_6600, -0xd_69b6);          /* call 0x10076600 */
            ii(0x1014_cfb6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_cfb8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_cfbb, 5); calld(0x1013_c25c, -0x1_0d64);          /* call 0x1013c25c */
            ii(0x1014_cfc0, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_cfc3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_cfc6, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1014_cfc9, 5); calld(0x100c_fd07, -0x7_d2c7);          /* call 0x100cfd07 */
            ii(0x1014_cfce, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_cfd0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_cfd1, 1); popd(edi);                              /* pop edi */
            ii(0x1014_cfd2, 1); popd(esi);                              /* pop esi */
            ii(0x1014_cfd3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_cfd4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_cfd5, 1); retd();                                 /* ret */
        }
    }
}
