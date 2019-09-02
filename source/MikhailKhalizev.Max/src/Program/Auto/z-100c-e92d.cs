using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_e92d-c69e5d46")]
        public void Method_100c_e92d()
        {
            ii(0x100c_e92d, 5); push(0xc0);                             /* push 0xc0 */
            ii(0x100c_e932, 5); call(Definitions.sys_check_available_stack_size, 0x9_741b); /* call 0x10165d52 */
            ii(0x100c_e937, 1); push(ebx);                              /* push ebx */
            ii(0x100c_e938, 1); push(ecx);                              /* push ecx */
            ii(0x100c_e939, 1); push(esi);                              /* push esi */
            ii(0x100c_e93a, 1); push(edi);                              /* push edi */
            ii(0x100c_e93b, 1); push(ebp);                              /* push ebp */
            ii(0x100c_e93c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_e93e, 6); sub(esp, 0xa4);                         /* sub esp, 0xa4 */
            ii(0x100c_e944, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_e947, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_e94a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_e94d, 3); mov(memd[ss, ebp - 38], eax);           /* mov [ebp-0x26], eax */
            ii(0x100c_e950, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_e953, 5); call(/* sys */ 0x1016_7dd4, 0x9_947c);  /* call 0x10167dd4 */
            ii(0x100c_e958, 3); mov(memd[ss, ebp - 34], eax);           /* mov [ebp-0x22], eax */
            ii(0x100c_e95b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_e95e, 5); call(/* sys */ 0x1016_7e3c, 0x9_94d9);  /* call 0x10167e3c */
            ii(0x100c_e963, 4); mov(memw[ss, ebp - 40], ax);            /* mov [ebp-0x28], ax */
            ii(0x100c_e967, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_e96c, 5); call(Definitions.sys_new, 0x9_748f);    /* call 0x10165e00 */
            ii(0x100c_e971, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100c_e974, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100c_e977, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100c_e97a, 4); cmp(memd[ss, ebp - 24], 0);             /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100c_e97e, 2); if(jz(0x100c_e9b8, 0x38)) goto l_0x100c_e9b8; /* jz 0x100ce9b8 */
            ii(0x100c_e980, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e983, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100c_e986, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_e989, 1); push(eax);                              /* push eax */
            ii(0x100c_e98a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e98d, 3); mov(ecx, memd[ds, eax + 6]);            /* mov ecx, [eax+0x6] */
            ii(0x100c_e990, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_e993, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e996, 3); mov(ebx, memd[ds, eax + 4]);            /* mov ebx, [eax+0x4] */
            ii(0x100c_e999, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_e99c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e99f, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100c_e9a2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_e9a5, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100c_e9a8, 5); call(0x100d_7bdc, 0x922f);              /* call 0x100d7bdc */
            ii(0x100c_e9ad, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100c_e9b0, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100c_e9b3, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100c_e9b6, 2); jmp(0x100c_e9be, 6); goto l_0x100c_e9be; /* jmp 0x100ce9be */
        l_0x100c_e9b8:
            ii(0x100c_e9b8, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100c_e9bb, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
        l_0x100c_e9be:
            ii(0x100c_e9be, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_e9c1, 3); mov(memd[ss, ebp - 60], eax);           /* mov [ebp-0x3c], eax */
            ii(0x100c_e9c4, 3); lea(edx, memd[ss, ebp - 56]);           /* lea edx, [ebp-0x38] */
            ii(0x100c_e9c7, 3); mov(eax, memd[ss, ebp - 60]);           /* mov eax, [ebp-0x3c] */
            ii(0x100c_e9ca, 5); call(0x100d_7d74, 0x93a5);              /* call 0x100d7d74 */
            ii(0x100c_e9cf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e9d2, 4); cmp(memd[ds, eax + 12], 0);             /* cmp dword [eax+0xc], 0x0 */
            ii(0x100c_e9d6, 6); if(jz(0x100c_ea85, 0xa9)) goto l_0x100c_ea85; /* jz 0x100cea85 */
            ii(0x100c_e9dc, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_e9e1, 5); call(Definitions.sys_new, 0x9_741a);    /* call 0x10165e00 */
            ii(0x100c_e9e6, 3); mov(memd[ss, ebp - 64], eax);           /* mov [ebp-0x40], eax */
            ii(0x100c_e9e9, 3); mov(eax, memd[ss, ebp - 64]);           /* mov eax, [ebp-0x40] */
            ii(0x100c_e9ec, 3); mov(memd[ss, ebp - 68], eax);           /* mov [ebp-0x44], eax */
            ii(0x100c_e9ef, 4); cmp(memd[ss, ebp - 68], 0);             /* cmp dword [ebp-0x44], 0x0 */
            ii(0x100c_e9f3, 2); if(jz(0x100c_ea2d, 0x38)) goto l_0x100c_ea2d; /* jz 0x100cea2d */
            ii(0x100c_e9f5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e9f8, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100c_e9fb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_e9fe, 1); push(eax);                              /* push eax */
            ii(0x100c_e9ff, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ea02, 3); mov(ecx, memd[ds, eax + 6]);            /* mov ecx, [eax+0x6] */
            ii(0x100c_ea05, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_ea08, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ea0b, 3); mov(ebx, memd[ds, eax + 4]);            /* mov ebx, [eax+0x4] */
            ii(0x100c_ea0e, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_ea11, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ea14, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100c_ea17, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_ea1a, 3); mov(eax, memd[ss, ebp - 64]);           /* mov eax, [ebp-0x40] */
            ii(0x100c_ea1d, 5); call(0x100d_7bdc, 0x91ba);              /* call 0x100d7bdc */
            ii(0x100c_ea22, 3); mov(memd[ss, ebp - 72], eax);           /* mov [ebp-0x48], eax */
            ii(0x100c_ea25, 3); mov(eax, memd[ss, ebp - 72]);           /* mov eax, [ebp-0x48] */
            ii(0x100c_ea28, 3); mov(memd[ss, ebp - 76], eax);           /* mov [ebp-0x4c], eax */
            ii(0x100c_ea2b, 2); jmp(0x100c_ea33, 6); goto l_0x100c_ea33; /* jmp 0x100cea33 */
        l_0x100c_ea2d:
            ii(0x100c_ea2d, 3); mov(eax, memd[ss, ebp - 68]);           /* mov eax, [ebp-0x44] */
            ii(0x100c_ea30, 3); mov(memd[ss, ebp - 76], eax);           /* mov [ebp-0x4c], eax */
        l_0x100c_ea33:
            ii(0x100c_ea33, 3); mov(eax, memd[ss, ebp - 76]);           /* mov eax, [ebp-0x4c] */
            ii(0x100c_ea36, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x100c_ea39, 3); mov(edx, memd[ss, ebp - 60]);           /* mov edx, [ebp-0x3c] */
            ii(0x100c_ea3c, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100c_ea3f, 5); call(0x100d_7e01, 0x93bd);              /* call 0x100d7e01 */
            ii(0x100c_ea44, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ea47, 3); mov(edx, memd[ds, eax + 12]);           /* mov edx, [eax+0xc] */
            ii(0x100c_ea4a, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100c_ea4d, 5); call(0x100d_7e88, 0x9436);              /* call 0x100d7e88 */
            ii(0x100c_ea52, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ea55, 3); mov(eax, memd[ds, eax + 12]);           /* mov eax, [eax+0xc] */
            ii(0x100c_ea58, 3); mov(memd[ss, ebp - 84], eax);           /* mov [ebp-0x54], eax */
            ii(0x100c_ea5b, 4); cmp(memd[ss, ebp - 84], 0);             /* cmp dword [ebp-0x54], 0x0 */
            ii(0x100c_ea5f, 2); if(jz(0x100c_ea75, 0x14)) goto l_0x100c_ea75; /* jz 0x100cea75 */
            ii(0x100c_ea61, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_ea63, 3); mov(eax, memd[ss, ebp - 84]);           /* mov eax, [ebp-0x54] */
            ii(0x100c_ea66, 5); call(Definitions.my_dtor_d3, 0x92c8);   /* call 0x100d7d33 */
            ii(0x100c_ea6b, 5); call(Definitions.sys_delete, 0x9_74f4); /* call 0x10165f64 */
            ii(0x100c_ea70, 3); mov(memd[ss, ebp - 88], eax);           /* mov [ebp-0x58], eax */
            ii(0x100c_ea73, 2); jmp(0x100c_ea7c, 7); goto l_0x100c_ea7c; /* jmp 0x100cea7c */
        l_0x100c_ea75:
            ii(0x100c_ea75, 7); mov(memd[ss, ebp - 88], 0);             /* mov dword [ebp-0x58], 0x0 */
        l_0x100c_ea7c:
            ii(0x100c_ea7c, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100c_ea7f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_ea82, 3); mov(memd[ds, edx + 12], eax);           /* mov [edx+0xc], eax */
        l_0x100c_ea85:
            ii(0x100c_ea85, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ea88, 4); cmp(memd[ds, eax + 16], 0);             /* cmp dword [eax+0x10], 0x0 */
            ii(0x100c_ea8c, 6); if(jz(0x100c_eb3b, 0xa9)) goto l_0x100c_eb3b; /* jz 0x100ceb3b */
            ii(0x100c_ea92, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_ea97, 5); call(Definitions.sys_new, 0x9_7364);    /* call 0x10165e00 */
            ii(0x100c_ea9c, 3); mov(memd[ss, ebp - 92], eax);           /* mov [ebp-0x5c], eax */
            ii(0x100c_ea9f, 3); mov(eax, memd[ss, ebp - 92]);           /* mov eax, [ebp-0x5c] */
            ii(0x100c_eaa2, 3); mov(memd[ss, ebp - 96], eax);           /* mov [ebp-0x60], eax */
            ii(0x100c_eaa5, 4); cmp(memd[ss, ebp - 96], 0);             /* cmp dword [ebp-0x60], 0x0 */
            ii(0x100c_eaa9, 2); if(jz(0x100c_eae3, 0x38)) goto l_0x100c_eae3; /* jz 0x100ceae3 */
            ii(0x100c_eaab, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_eaae, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100c_eab1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_eab4, 1); push(eax);                              /* push eax */
            ii(0x100c_eab5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_eab8, 3); mov(ecx, memd[ds, eax + 6]);            /* mov ecx, [eax+0x6] */
            ii(0x100c_eabb, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_eabe, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_eac1, 3); mov(ebx, memd[ds, eax + 4]);            /* mov ebx, [eax+0x4] */
            ii(0x100c_eac4, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_eac7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_eaca, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100c_eacd, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_ead0, 3); mov(eax, memd[ss, ebp - 92]);           /* mov eax, [ebp-0x5c] */
            ii(0x100c_ead3, 5); call(0x100d_7bdc, 0x9104);              /* call 0x100d7bdc */
            ii(0x100c_ead8, 3); mov(memd[ss, ebp - 100], eax);          /* mov [ebp-0x64], eax */
            ii(0x100c_eadb, 3); mov(eax, memd[ss, ebp - 100]);          /* mov eax, [ebp-0x64] */
            ii(0x100c_eade, 3); mov(memd[ss, ebp - 104], eax);          /* mov [ebp-0x68], eax */
            ii(0x100c_eae1, 2); jmp(0x100c_eae9, 6); goto l_0x100c_eae9; /* jmp 0x100ceae9 */
        l_0x100c_eae3:
            ii(0x100c_eae3, 3); mov(eax, memd[ss, ebp - 96]);           /* mov eax, [ebp-0x60] */
            ii(0x100c_eae6, 3); mov(memd[ss, ebp - 104], eax);          /* mov [ebp-0x68], eax */
        l_0x100c_eae9:
            ii(0x100c_eae9, 3); mov(eax, memd[ss, ebp - 104]);          /* mov eax, [ebp-0x68] */
            ii(0x100c_eaec, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x100c_eaef, 3); mov(edx, memd[ss, ebp - 60]);           /* mov edx, [ebp-0x3c] */
            ii(0x100c_eaf2, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100c_eaf5, 5); call(0x100d_7e01, 0x9307);              /* call 0x100d7e01 */
            ii(0x100c_eafa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_eafd, 3); mov(edx, memd[ds, eax + 16]);           /* mov edx, [eax+0x10] */
            ii(0x100c_eb00, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100c_eb03, 5); call(0x100d_7e88, 0x9380);              /* call 0x100d7e88 */
            ii(0x100c_eb08, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_eb0b, 3); mov(eax, memd[ds, eax + 16]);           /* mov eax, [eax+0x10] */
            ii(0x100c_eb0e, 3); mov(memd[ss, ebp - 108], eax);          /* mov [ebp-0x6c], eax */
            ii(0x100c_eb11, 4); cmp(memd[ss, ebp - 108], 0);            /* cmp dword [ebp-0x6c], 0x0 */
            ii(0x100c_eb15, 2); if(jz(0x100c_eb2b, 0x14)) goto l_0x100c_eb2b; /* jz 0x100ceb2b */
            ii(0x100c_eb17, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_eb19, 3); mov(eax, memd[ss, ebp - 108]);          /* mov eax, [ebp-0x6c] */
            ii(0x100c_eb1c, 5); call(Definitions.my_dtor_d3, 0x9212);   /* call 0x100d7d33 */
            ii(0x100c_eb21, 5); call(Definitions.sys_delete, 0x9_743e); /* call 0x10165f64 */
            ii(0x100c_eb26, 3); mov(memd[ss, ebp - 112], eax);          /* mov [ebp-0x70], eax */
            ii(0x100c_eb29, 2); jmp(0x100c_eb32, 7); goto l_0x100c_eb32; /* jmp 0x100ceb32 */
        l_0x100c_eb2b:
            ii(0x100c_eb2b, 7); mov(memd[ss, ebp - 112], 0);            /* mov dword [ebp-0x70], 0x0 */
        l_0x100c_eb32:
            ii(0x100c_eb32, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100c_eb35, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_eb38, 3); mov(memd[ds, edx + 16], eax);           /* mov [edx+0x10], eax */
        l_0x100c_eb3b:
            ii(0x100c_eb3b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_eb3e, 4); cmp(memd[ds, eax + 20], 0);             /* cmp dword [eax+0x14], 0x0 */
            ii(0x100c_eb42, 6); if(jz(0x100c_ec00, 0xb8)) goto l_0x100c_ec00; /* jz 0x100cec00 */
            ii(0x100c_eb48, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_eb4d, 5); call(Definitions.sys_new, 0x9_72ae);    /* call 0x10165e00 */
            ii(0x100c_eb52, 3); mov(memd[ss, ebp - 116], eax);          /* mov [ebp-0x74], eax */
            ii(0x100c_eb55, 3); mov(eax, memd[ss, ebp - 116]);          /* mov eax, [ebp-0x74] */
            ii(0x100c_eb58, 3); mov(memd[ss, ebp - 120], eax);          /* mov [ebp-0x78], eax */
            ii(0x100c_eb5b, 4); cmp(memd[ss, ebp - 120], 0);            /* cmp dword [ebp-0x78], 0x0 */
            ii(0x100c_eb5f, 2); if(jz(0x100c_eb99, 0x38)) goto l_0x100c_eb99; /* jz 0x100ceb99 */
            ii(0x100c_eb61, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_eb64, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100c_eb67, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_eb6a, 1); push(eax);                              /* push eax */
            ii(0x100c_eb6b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_eb6e, 3); mov(ecx, memd[ds, eax + 6]);            /* mov ecx, [eax+0x6] */
            ii(0x100c_eb71, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_eb74, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_eb77, 3); mov(ebx, memd[ds, eax + 4]);            /* mov ebx, [eax+0x4] */
            ii(0x100c_eb7a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_eb7d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_eb80, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100c_eb83, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_eb86, 3); mov(eax, memd[ss, ebp - 116]);          /* mov eax, [ebp-0x74] */
            ii(0x100c_eb89, 5); call(0x100d_7bdc, 0x904e);              /* call 0x100d7bdc */
            ii(0x100c_eb8e, 3); mov(memd[ss, ebp - 124], eax);          /* mov [ebp-0x7c], eax */
            ii(0x100c_eb91, 3); mov(eax, memd[ss, ebp - 124]);          /* mov eax, [ebp-0x7c] */
            ii(0x100c_eb94, 3); mov(memd[ss, ebp - 128], eax);          /* mov [ebp-0x80], eax */
            ii(0x100c_eb97, 2); jmp(0x100c_eb9f, 6); goto l_0x100c_eb9f; /* jmp 0x100ceb9f */
        l_0x100c_eb99:
            ii(0x100c_eb99, 3); mov(eax, memd[ss, ebp - 120]);          /* mov eax, [ebp-0x78] */
            ii(0x100c_eb9c, 3); mov(memd[ss, ebp - 128], eax);          /* mov [ebp-0x80], eax */
        l_0x100c_eb9f:
            ii(0x100c_eb9f, 3); mov(eax, memd[ss, ebp - 128]);          /* mov eax, [ebp-0x80] */
            ii(0x100c_eba2, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x100c_eba5, 3); mov(edx, memd[ss, ebp - 60]);           /* mov edx, [ebp-0x3c] */
            ii(0x100c_eba8, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100c_ebab, 5); call(0x100d_7e01, 0x9251);              /* call 0x100d7e01 */
            ii(0x100c_ebb0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ebb3, 3); mov(edx, memd[ds, eax + 20]);           /* mov edx, [eax+0x14] */
            ii(0x100c_ebb6, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100c_ebb9, 5); call(0x100d_7e88, 0x92ca);              /* call 0x100d7e88 */
            ii(0x100c_ebbe, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ebc1, 3); mov(eax, memd[ds, eax + 20]);           /* mov eax, [eax+0x14] */
            ii(0x100c_ebc4, 6); mov(memd[ss, ebp - 132], eax);          /* mov [ebp-0x84], eax */
            ii(0x100c_ebca, 7); cmp(memd[ss, ebp - 132], 0);            /* cmp dword [ebp-0x84], 0x0 */
            ii(0x100c_ebd1, 2); if(jz(0x100c_ebed, 0x1a)) goto l_0x100c_ebed; /* jz 0x100cebed */
            ii(0x100c_ebd3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_ebd5, 6); mov(eax, memd[ss, ebp - 132]);          /* mov eax, [ebp-0x84] */
            ii(0x100c_ebdb, 5); call(Definitions.my_dtor_d3, 0x9153);   /* call 0x100d7d33 */
            ii(0x100c_ebe0, 5); call(Definitions.sys_delete, 0x9_737f); /* call 0x10165f64 */
            ii(0x100c_ebe5, 6); mov(memd[ss, ebp - 136], eax);          /* mov [ebp-0x88], eax */
            ii(0x100c_ebeb, 2); jmp(0x100c_ebf7, 0xa); goto l_0x100c_ebf7; /* jmp 0x100cebf7 */
        l_0x100c_ebed:
            ii(0x100c_ebed, 10); mov(memd[ss, ebp - 136], 0);           /* mov dword [ebp-0x88], 0x0 */
        l_0x100c_ebf7:
            ii(0x100c_ebf7, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100c_ebfa, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_ebfd, 3); mov(memd[ds, edx + 20], eax);           /* mov [edx+0x14], eax */
        l_0x100c_ec00:
            ii(0x100c_ec00, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ec03, 4); cmp(memd[ds, eax + 24], 0);             /* cmp dword [eax+0x18], 0x0 */
            ii(0x100c_ec07, 6); if(jz(0x100c_ece6, 0xd9)) goto l_0x100c_ece6; /* jz 0x100cece6 */
            ii(0x100c_ec0d, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_ec12, 5); call(Definitions.sys_new, 0x9_71e9);    /* call 0x10165e00 */
            ii(0x100c_ec17, 6); mov(memd[ss, ebp - 140], eax);          /* mov [ebp-0x8c], eax */
            ii(0x100c_ec1d, 6); mov(eax, memd[ss, ebp - 140]);          /* mov eax, [ebp-0x8c] */
            ii(0x100c_ec23, 6); mov(memd[ss, ebp - 144], eax);          /* mov [ebp-0x90], eax */
            ii(0x100c_ec29, 7); cmp(memd[ss, ebp - 144], 0);            /* cmp dword [ebp-0x90], 0x0 */
            ii(0x100c_ec30, 2); if(jz(0x100c_ec76, 0x44)) goto l_0x100c_ec76; /* jz 0x100cec76 */
            ii(0x100c_ec32, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ec35, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100c_ec38, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_ec3b, 1); push(eax);                              /* push eax */
            ii(0x100c_ec3c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ec3f, 3); mov(ecx, memd[ds, eax + 6]);            /* mov ecx, [eax+0x6] */
            ii(0x100c_ec42, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_ec45, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ec48, 3); mov(ebx, memd[ds, eax + 4]);            /* mov ebx, [eax+0x4] */
            ii(0x100c_ec4b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_ec4e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ec51, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100c_ec54, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_ec57, 6); mov(eax, memd[ss, ebp - 140]);          /* mov eax, [ebp-0x8c] */
            ii(0x100c_ec5d, 5); call(0x100d_7bdc, 0x8f7a);              /* call 0x100d7bdc */
            ii(0x100c_ec62, 6); mov(memd[ss, ebp - 148], eax);          /* mov [ebp-0x94], eax */
            ii(0x100c_ec68, 6); mov(eax, memd[ss, ebp - 148]);          /* mov eax, [ebp-0x94] */
            ii(0x100c_ec6e, 6); mov(memd[ss, ebp - 152], eax);          /* mov [ebp-0x98], eax */
            ii(0x100c_ec74, 2); jmp(0x100c_ec82, 0xc); goto l_0x100c_ec82; /* jmp 0x100cec82 */
        l_0x100c_ec76:
            ii(0x100c_ec76, 6); mov(eax, memd[ss, ebp - 144]);          /* mov eax, [ebp-0x90] */
            ii(0x100c_ec7c, 6); mov(memd[ss, ebp - 152], eax);          /* mov [ebp-0x98], eax */
        l_0x100c_ec82:
            ii(0x100c_ec82, 6); mov(eax, memd[ss, ebp - 152]);          /* mov eax, [ebp-0x98] */
            ii(0x100c_ec88, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x100c_ec8b, 3); mov(edx, memd[ss, ebp - 60]);           /* mov edx, [ebp-0x3c] */
            ii(0x100c_ec8e, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100c_ec91, 5); call(0x100d_7e01, 0x916b);              /* call 0x100d7e01 */
            ii(0x100c_ec96, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ec99, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x100c_ec9c, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100c_ec9f, 5); call(0x100d_7e88, 0x91e4);              /* call 0x100d7e88 */
            ii(0x100c_eca4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_eca7, 3); mov(eax, memd[ds, eax + 24]);           /* mov eax, [eax+0x18] */
            ii(0x100c_ecaa, 6); mov(memd[ss, ebp - 156], eax);          /* mov [ebp-0x9c], eax */
            ii(0x100c_ecb0, 7); cmp(memd[ss, ebp - 156], 0);            /* cmp dword [ebp-0x9c], 0x0 */
            ii(0x100c_ecb7, 2); if(jz(0x100c_ecd3, 0x1a)) goto l_0x100c_ecd3; /* jz 0x100cecd3 */
            ii(0x100c_ecb9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_ecbb, 6); mov(eax, memd[ss, ebp - 156]);          /* mov eax, [ebp-0x9c] */
            ii(0x100c_ecc1, 5); call(Definitions.my_dtor_d3, 0x906d);   /* call 0x100d7d33 */
            ii(0x100c_ecc6, 5); call(Definitions.sys_delete, 0x9_7299); /* call 0x10165f64 */
            ii(0x100c_eccb, 6); mov(memd[ss, ebp - 160], eax);          /* mov [ebp-0xa0], eax */
            ii(0x100c_ecd1, 2); jmp(0x100c_ecdd, 0xa); goto l_0x100c_ecdd; /* jmp 0x100cecdd */
        l_0x100c_ecd3:
            ii(0x100c_ecd3, 10); mov(memd[ss, ebp - 160], 0);           /* mov dword [ebp-0xa0], 0x0 */
        l_0x100c_ecdd:
            ii(0x100c_ecdd, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100c_ece0, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_ece3, 3); mov(memd[ds, edx + 24], eax);           /* mov [edx+0x18], eax */
        l_0x100c_ece6:
            ii(0x100c_ece6, 3); mov(eax, memd[ss, ebp - 60]);           /* mov eax, [ebp-0x3c] */
            ii(0x100c_ece9, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100c_ecec, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100c_ecf0, 2); if(jz(0x100c_ed09, 0x17)) goto l_0x100c_ed09; /* jz 0x100ced09 */
            ii(0x100c_ecf2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_ecf4, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_ecf7, 5); call(Definitions.my_dtor_d3, 0x9037);   /* call 0x100d7d33 */
            ii(0x100c_ecfc, 5); call(Definitions.sys_delete, 0x9_7263); /* call 0x10165f64 */
            ii(0x100c_ed01, 6); mov(memd[ss, ebp - 164], eax);          /* mov [ebp-0xa4], eax */
            ii(0x100c_ed07, 2); jmp(0x100c_ed13, 0xa); goto l_0x100c_ed13; /* jmp 0x100ced13 */
        l_0x100c_ed09:
            ii(0x100c_ed09, 10); mov(memd[ss, ebp - 164], 0);           /* mov dword [ebp-0xa4], 0x0 */
        l_0x100c_ed13:
            ii(0x100c_ed13, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ed15, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_ed16, 1); pop(edi);                               /* pop edi */
            ii(0x100c_ed17, 1); pop(esi);                               /* pop esi */
            ii(0x100c_ed18, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_ed19, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_ed1a, 1); ret();                                  /* ret */
        }
    }
}
