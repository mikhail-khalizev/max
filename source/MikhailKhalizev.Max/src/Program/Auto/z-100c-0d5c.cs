using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_0d5c-5a76c269")]
        public void Method_100c_0d5c()
        {
            ii(0x100c_0d5c, 5); push(0x74);                             /* push 0x74 */
            ii(0x100c_0d61, 5); call(Definitions.sys_check_available_stack_size, 0xa_4fec); /* call 0x10165d52 */
            ii(0x100c_0d66, 1); push(esi);                              /* push esi */
            ii(0x100c_0d67, 1); push(edi);                              /* push edi */
            ii(0x100c_0d68, 1); push(ebp);                              /* push ebp */
            ii(0x100c_0d69, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_0d6b, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x100c_0d71, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_0d74, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100c_0d77, 3); mov(memb[ss, ebp - 0x4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100c_0d7a, 3); mov(memd[ss, ebp - 0x8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x100c_0d7d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_0d80, 5); call(0x1007_623c, -0x4_ab49);           /* call 0x1007623c */
            ii(0x100c_0d85, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_0d88, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_0d8b, 4); test(memb[ds, eax + 0x12], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x100c_0d8f, 2); if(jz(0x100c_0d9a, 0x9)) goto l_0x100c_0d9a; /* jz 0x100c0d9a */
            ii(0x100c_0d91, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x100c_0d94, 4); cmp(memd[ds, eax + 0x8], 0);            /* cmp dword [eax+0x8], 0x0 */
            ii(0x100c_0d98, 2); if(jnz(0x100c_0d9c, 0x2)) goto l_0x100c_0d9c; /* jnz 0x100c0d9c */
        l_0x100c_0d9a:
            ii(0x100c_0d9a, 2); jmp(0x100c_0da2, 0x6); goto l_0x100c_0da2; /* jmp 0x100c0da2 */
        l_0x100c_0d9c:
            ii(0x100c_0d9c, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x100c_0d9f, 3); mov(memd[ss, ebp + 0x14], eax);         /* mov [ebp+0x14], eax */
        l_0x100c_0da2:
            ii(0x100c_0da2, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_0da5, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x100c_0da8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_0dad, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_0daf, 2); if(jle(0x100c_0dc4, 0x13)) goto l_0x100c_0dc4; /* jle 0x100c0dc4 */
            ii(0x100c_0db1, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_0db4, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100c_0db7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_0dbc, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x100c_0dbf, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x100c_0dc2, 2); if(jz(0x100c_0dc6, 0x2)) goto l_0x100c_0dc6; /* jz 0x100c0dc6 */
        l_0x100c_0dc4:
            ii(0x100c_0dc4, 2); jmp(0x100c_0dcb, 0x5); goto l_0x100c_0dcb; /* jmp 0x100c0dcb */
        l_0x100c_0dc6:
            ii(0x100c_0dc6, 5); jmp(0x100c_10e7, 0x31c); goto l_0x100c_10e7; /* jmp 0x100c10e7 */
        l_0x100c_0dcb:
            ii(0x100c_0dcb, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_0dce, 4); mov(ax, memw[ds, eax + 0x12]);          /* mov ax, [eax+0x12] */
            ii(0x100c_0dd2, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_0dd5, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_0dd8, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100c_0ddb, 4); add(ax, memw[ds, edx + 0x1d]);          /* add ax, [edx+0x1d] */
            ii(0x100c_0ddf, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100c_0de2, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_0de5, 5); call(0x1007_623c, -0x4_abae);           /* call 0x1007623c */
            ii(0x100c_0dea, 4); mov(ax, memw[ds, eax + 0xe]);           /* mov ax, [eax+0xe] */
            ii(0x100c_0dee, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100c_0df1, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_0df4, 4); mov(ax, memw[ds, eax + 0x14]);          /* mov ax, [eax+0x14] */
            ii(0x100c_0df8, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100c_0dfb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_0dfd, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_0e00, 3); mov(al, memb[ds, edx + 0x54]);          /* mov al, [edx+0x54] */
            ii(0x100c_0e03, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100c_0e06, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x100c_0e09, 3); mov(memb[ss, ebp - 0x18], al);          /* mov [ebp-0x18], al */
            ii(0x100c_0e0c, 5); jmp(0x100c_10b9, 0x2a8); goto l_0x100c_10b9; /* jmp 0x100c10b9 */
        l_0x100c_0e11:
            ii(0x100c_0e11, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_0e13, 1); push(eax);                              /* push eax */
            ii(0x100c_0e14, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100c_0e17, 1); push(eax);                              /* push eax */
            ii(0x100c_0e18, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_0e1b, 3); mov(al, memb[ds, eax + 0x50]);          /* mov al, [eax+0x50] */
            ii(0x100c_0e1e, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100c_0e20, 1); cwde();                                 /* cwde */
            ii(0x100c_0e21, 1); push(eax);                              /* push eax */
            ii(0x100c_0e22, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100c_0e26, 1); push(eax);                              /* push eax */
            ii(0x100c_0e27, 4); movsx(ecx, memw[ss, ebp - 0x1c]);       /* movsx ecx, word [ebp-0x1c] */
            ii(0x100c_0e2b, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_0e2e, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100c_0e31, 5); call(0x1007_5e64, -0x4_afd2);           /* call 0x10075e64 */
            ii(0x100c_0e36, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_0e39, 3); mov(esi, memd[ss, ebp + 0x14]);         /* mov esi, [ebp+0x14] */
            ii(0x100c_0e3c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_0e3e, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100c_0e40, 5); call(0x100c_0aae, -0x397);              /* call 0x100c0aae */
            ii(0x100c_0e45, 5); jmp(0x100c_10e7, 0x29d); goto l_0x100c_10e7; /* jmp 0x100c10e7 */
        l_0x100c_0e4a:
            ii(0x100c_0e4a, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_0e4d, 4); cmp(memb[ds, eax + 0x16], 0);           /* cmp byte [eax+0x16], 0x0 */
            ii(0x100c_0e51, 6); if(jz(0x100c_0f1b, 0xc4)) goto l_0x100c_0f1b; /* jz 0x100c0f1b */
            ii(0x100c_0e57, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_0e5c, 1); push(eax);                              /* push eax */
            ii(0x100c_0e5d, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100c_0e60, 1); push(eax);                              /* push eax */
            ii(0x100c_0e61, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_0e64, 3); mov(al, memb[ds, eax + 0x50]);          /* mov al, [eax+0x50] */
            ii(0x100c_0e67, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100c_0e69, 1); cwde();                                 /* cwde */
            ii(0x100c_0e6a, 1); push(eax);                              /* push eax */
            ii(0x100c_0e6b, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100c_0e6f, 1); push(eax);                              /* push eax */
            ii(0x100c_0e70, 4); movsx(ecx, memw[ss, ebp - 0x1c]);       /* movsx ecx, word [ebp-0x1c] */
            ii(0x100c_0e74, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_0e77, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x100c_0e7a, 5); call(0x1007_5e64, -0x4_b01b);           /* call 0x10075e64 */
            ii(0x100c_0e7f, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_0e82, 3); mov(esi, memd[ss, ebp + 0x14]);         /* mov esi, [ebp+0x14] */
            ii(0x100c_0e85, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_0e87, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100c_0e89, 5); call(0x100c_0aae, -0x3e0);              /* call 0x100c0aae */
            ii(0x100c_0e8e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_0e91, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100c_0e94, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_0e99, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x100c_0e9c, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x100c_0e9f, 2); if(jz(0x100c_0ee7, 0x46)) goto l_0x100c_0ee7; /* jz 0x100c0ee7 */
            ii(0x100c_0ea1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_0ea3, 1); push(eax);                              /* push eax */
            ii(0x100c_0ea4, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100c_0ea7, 1); push(eax);                              /* push eax */
            ii(0x100c_0ea8, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100c_0eac, 1); push(eax);                              /* push eax */
            ii(0x100c_0ead, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100c_0eb1, 1); push(eax);                              /* push eax */
            ii(0x100c_0eb2, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100c_0eb5, 3); mov(edx, memd[ds, edx + 0xe]);          /* mov edx, [edx+0xe] */
            ii(0x100c_0eb8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_0ebb, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_0ebd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_0ec0, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_0ec2, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100c_0ec4, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x100c_0ec8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_0eca, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100c_0ecd, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_0ed0, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x100c_0ed3, 5); call(0x1007_5e64, -0x4_b074);           /* call 0x10075e64 */
            ii(0x100c_0ed8, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_0eda, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_0edd, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x100c_0ee0, 5); call(0x100c_0aae, -0x437);              /* call 0x100c0aae */
            ii(0x100c_0ee5, 2); jmp(0x100c_0f16, 0x2f); goto l_0x100c_0f16; /* jmp 0x100c0f16 */
        l_0x100c_0ee7:
            ii(0x100c_0ee7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_0ee9, 1); push(eax);                              /* push eax */
            ii(0x100c_0eea, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100c_0eed, 1); push(eax);                              /* push eax */
            ii(0x100c_0eee, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100c_0ef2, 1); push(eax);                              /* push eax */
            ii(0x100c_0ef3, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100c_0ef7, 1); push(eax);                              /* push eax */
            ii(0x100c_0ef8, 4); movsx(ecx, memw[ss, ebp - 0x20]);       /* movsx ecx, word [ebp-0x20] */
            ii(0x100c_0efc, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_0eff, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x100c_0f02, 5); call(0x1007_5e64, -0x4_b0a3);           /* call 0x10075e64 */
            ii(0x100c_0f07, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_0f0a, 3); mov(esi, memd[ss, ebp + 0x14]);         /* mov esi, [ebp+0x14] */
            ii(0x100c_0f0d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_0f0f, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100c_0f11, 5); call(0x100c_0aae, -0x468);              /* call 0x100c0aae */
        l_0x100c_0f16:
            ii(0x100c_0f16, 5); jmp(0x100c_0fc9, 0xae); goto l_0x100c_0fc9; /* jmp 0x100c0fc9 */
        l_0x100c_0f1b:
            ii(0x100c_0f1b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_0f20, 1); push(eax);                              /* push eax */
            ii(0x100c_0f21, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100c_0f24, 1); push(eax);                              /* push eax */
            ii(0x100c_0f25, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_0f28, 3); mov(al, memb[ds, eax + 0x50]);          /* mov al, [eax+0x50] */
            ii(0x100c_0f2b, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100c_0f2d, 1); inc(eax);                               /* inc eax */
            ii(0x100c_0f2e, 1); cwde();                                 /* cwde */
            ii(0x100c_0f2f, 1); push(eax);                              /* push eax */
            ii(0x100c_0f30, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100c_0f34, 1); push(eax);                              /* push eax */
            ii(0x100c_0f35, 4); movsx(ecx, memw[ss, ebp - 0x1c]);       /* movsx ecx, word [ebp-0x1c] */
            ii(0x100c_0f39, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_0f3c, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x100c_0f3f, 5); call(0x1007_5e64, -0x4_b0e0);           /* call 0x10075e64 */
            ii(0x100c_0f44, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_0f47, 3); mov(esi, memd[ss, ebp + 0x14]);         /* mov esi, [ebp+0x14] */
            ii(0x100c_0f4a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_0f4c, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100c_0f4e, 5); call(0x100c_0aae, -0x4a5);              /* call 0x100c0aae */
            ii(0x100c_0f53, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_0f56, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100c_0f59, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_0f5e, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x100c_0f61, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x100c_0f64, 2); if(jz(0x100c_0fc9, 0x63)) goto l_0x100c_0fc9; /* jz 0x100c0fc9 */
        l_0x100c_0f66:
            ii(0x100c_0f66, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x100c_0f69, 3); dec(memd[ss, ebp - 0x28]);              /* dec dword [ebp-0x28] */
            ii(0x100c_0f6c, 1); cwde();                                 /* cwde */
            ii(0x100c_0f6d, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_0f70, 2); if(jle(0x100c_0fc9, 0x57)) goto l_0x100c_0fc9; /* jle 0x100c0fc9 */
            ii(0x100c_0f72, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_0f75, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x100c_0f78, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_0f7b, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x100c_0f7f, 1); inc(eax);                               /* inc eax */
            ii(0x100c_0f80, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_0f83, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100c_0f87, 3); lea(ebx, memd[ds, eax + 0x1]);          /* lea ebx, [eax+0x1] */
            ii(0x100c_0f8a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_0f8c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_0f8f, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100c_0f91, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100c_0f94, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_0f96, 1); push(eax);                              /* push eax */
            ii(0x100c_0f97, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100c_0f9a, 1); push(eax);                              /* push eax */
            ii(0x100c_0f9b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_0fa0, 1); push(eax);                              /* push eax */
            ii(0x100c_0fa1, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100c_0fa5, 1); push(eax);                              /* push eax */
            ii(0x100c_0fa6, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_0fa9, 3); add(eax, memd[ss, ebp - 0x44]);         /* add eax, [ebp-0x44] */
            ii(0x100c_0fac, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100c_0faf, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_0fb2, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x100c_0fb5, 5); call(0x1007_5e64, -0x4_b156);           /* call 0x10075e64 */
            ii(0x100c_0fba, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_0fbc, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_0fbf, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x100c_0fc2, 5); call(0x100c_0aae, -0x519);              /* call 0x100c0aae */
            ii(0x100c_0fc7, 2); jmp(0x100c_0f66, -0x63); goto l_0x100c_0f66; /* jmp 0x100c0f66 */
        l_0x100c_0fc9:
            ii(0x100c_0fc9, 5); jmp(0x100c_10e7, 0x119); goto l_0x100c_10e7; /* jmp 0x100c10e7 */
        l_0x100c_0fce:
            ii(0x100c_0fce, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100c_0fd3, 1); push(eax);                              /* push eax */
            ii(0x100c_0fd4, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100c_0fd7, 1); push(eax);                              /* push eax */
            ii(0x100c_0fd8, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100c_0fdc, 1); push(eax);                              /* push eax */
            ii(0x100c_0fdd, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100c_0fe1, 1); push(eax);                              /* push eax */
            ii(0x100c_0fe2, 4); movsx(ecx, memw[ss, ebp - 0x20]);       /* movsx ecx, word [ebp-0x20] */
            ii(0x100c_0fe6, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_0fe9, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x100c_0fec, 5); call(0x1007_5e64, -0x4_b18d);           /* call 0x10075e64 */
            ii(0x100c_0ff1, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_0ff4, 3); mov(esi, memd[ss, ebp + 0x14]);         /* mov esi, [ebp+0x14] */
            ii(0x100c_0ff7, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_0ff9, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100c_0ffb, 5); call(0x100c_0aae, -0x552);              /* call 0x100c0aae */
            ii(0x100c_1000, 7); mov(memd[ss, ebp - 0x44], 0);           /* mov dword [ebp-0x44], 0x0 */
            ii(0x100c_1007, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_100a, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100c_100d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_1012, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x100c_1015, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x100c_1018, 2); if(jz(0x100c_1079, 0x5f)) goto l_0x100c_1079; /* jz 0x100c1079 */
            ii(0x100c_101a, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_101d, 4); cmp(memb[ds, eax + 0x16], 0);           /* cmp byte [eax+0x16], 0x0 */
            ii(0x100c_1021, 2); if(jz(0x100c_103a, 0x17)) goto l_0x100c_103a; /* jz 0x100c103a */
            ii(0x100c_1023, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100c_1026, 3); mov(edx, memd[ds, edx + 0xe]);          /* mov edx, [edx+0xe] */
            ii(0x100c_1029, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_102c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_102e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_1031, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_1033, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100c_1035, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100c_1038, 2); jmp(0x100c_1079, 0x3f); goto l_0x100c_1079; /* jmp 0x100c1079 */
        l_0x100c_103a:
            ii(0x100c_103a, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100c_103d, 3); mov(eax, memd[ds, edx + 0xe]);          /* mov eax, [edx+0xe] */
            ii(0x100c_1040, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_1043, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x100c_1047, 1); inc(eax);                               /* inc eax */
            ii(0x100c_1048, 1); dec(edx);                               /* dec edx */
            ii(0x100c_1049, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_104c, 4); movsx(ebx, memw[ss, ebp - 0x28]);       /* movsx ebx, word [ebp-0x28] */
            ii(0x100c_1050, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_1052, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_1055, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100c_1057, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100c_105a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_105c, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100c_1061, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_1063, 2); if(jz(0x100c_1079, 0x14)) goto l_0x100c_1079; /* jz 0x100c1079 */
            ii(0x100c_1065, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_1068, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_106a, 3); mov(dl, memb[ds, eax + 0x4e]);          /* mov dl, [eax+0x4e] */
            ii(0x100c_106d, 4); movsx(eax, memw[ss, ebp - 0x44]);       /* movsx eax, word [ebp-0x44] */
            ii(0x100c_1071, 5); call(0x1007_6e7c, -0x4_a1fa);           /* call 0x10076e7c */
            ii(0x100c_1076, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
        l_0x100c_1079:
            ii(0x100c_1079, 4); movsx(eax, memw[ss, ebp - 0x44]);       /* movsx eax, word [ebp-0x44] */
            ii(0x100c_107d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_107f, 2); if(jle(0x100c_10b5, 0x34)) goto l_0x100c_10b5; /* jle 0x100c10b5 */
            ii(0x100c_1081, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_1083, 1); push(eax);                              /* push eax */
            ii(0x100c_1084, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x100c_1087, 1); push(eax);                              /* push eax */
            ii(0x100c_1088, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100c_108c, 1); push(eax);                              /* push eax */
            ii(0x100c_108d, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100c_1091, 1); push(eax);                              /* push eax */
            ii(0x100c_1092, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_1095, 3); add(eax, memd[ss, ebp - 0x44]);         /* add eax, [ebp-0x44] */
            ii(0x100c_1098, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100c_109b, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_109e, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x100c_10a1, 5); call(0x1007_5e64, -0x4_b242);           /* call 0x10075e64 */
            ii(0x100c_10a6, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_10a9, 3); mov(esi, memd[ss, ebp + 0x14]);         /* mov esi, [ebp+0x14] */
            ii(0x100c_10ac, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_10ae, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100c_10b0, 5); call(0x100c_0aae, -0x607);              /* call 0x100c0aae */
        l_0x100c_10b5:
            ii(0x100c_10b5, 2); jmp(0x100c_10e7, 0x30); goto l_0x100c_10e7; /* jmp 0x100c10e7 */
        l_0x100c_10b7:
            ii(0x100c_10b7, 2); jmp(0x100c_10e7, 0x2e); goto l_0x100c_10e7; /* jmp 0x100c10e7 */
        l_0x100c_10b9:
            ii(0x100c_10b9, 3); mov(al, memb[ss, ebp - 0x18]);          /* mov al, [ebp-0x18] */
            ii(0x100c_10bc, 3); mov(memb[ss, ebp - 0x54], al);          /* mov [ebp-0x54], al */
            ii(0x100c_10bf, 4); cmp(memb[ss, ebp - 0x54], 0x2);         /* cmp byte [ebp-0x54], 0x2 */
            ii(0x100c_10c3, 2); if(jb(0x100c_10db, 0x16)) goto l_0x100c_10db; /* jb 0x100c10db */
            ii(0x100c_10c5, 4); cmp(memb[ss, ebp - 0x54], 0x2);         /* cmp byte [ebp-0x54], 0x2 */
            ii(0x100c_10c9, 6); if(jbe(0x100c_0e4a, -0x285)) goto l_0x100c_0e4a; /* jbe 0x100c0e4a */
            ii(0x100c_10cf, 4); cmp(memb[ss, ebp - 0x54], 0x3);         /* cmp byte [ebp-0x54], 0x3 */
            ii(0x100c_10d3, 6); if(jz(0x100c_0fce, -0x10b)) goto l_0x100c_0fce; /* jz 0x100c0fce */
            ii(0x100c_10d9, 2); jmp(0x100c_10b7, -0x24); goto l_0x100c_10b7; /* jmp 0x100c10b7 */
        l_0x100c_10db:
            ii(0x100c_10db, 4); cmp(memb[ss, ebp - 0x54], 0x1);         /* cmp byte [ebp-0x54], 0x1 */
            ii(0x100c_10df, 6); if(jz(0x100c_0e11, -0x2d4)) goto l_0x100c_0e11; /* jz 0x100c0e11 */
            ii(0x100c_10e5, 2); jmp(0x100c_10b7, -0x30); goto l_0x100c_10b7; /* jmp 0x100c10b7 */
        l_0x100c_10e7:
            ii(0x100c_10e7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_10e9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_10ea, 1); pop(edi);                               /* pop edi */
            ii(0x100c_10eb, 1); pop(esi);                               /* pop esi */
            ii(0x100c_10ec, 3); ret(0x8);                               /* ret 0x8 */
        }
    }
}
