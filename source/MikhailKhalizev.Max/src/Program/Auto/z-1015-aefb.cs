using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_aefb-26b3aa26")]
        public void Method_1015_aefb()
        {
            ii(0x1015_aefb, 5); push(0x64);                             /* push 0x64 */
            ii(0x1015_af00, 5); call(Definitions.sys_check_available_stack_size, 0xae4d); /* call 0x10165d52 */
            ii(0x1015_af05, 1); push(esi);                              /* push esi */
            ii(0x1015_af06, 1); push(edi);                              /* push edi */
            ii(0x1015_af07, 1); push(ebp);                              /* push ebp */
            ii(0x1015_af08, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_af0a, 6); sub(esp, 0x50);                         /* sub esp, 0x50 */
            ii(0x1015_af10, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_af13, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1015_af16, 3); mov(memb[ss, ebp - 0x4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1015_af19, 3); mov(memd[ss, ebp - 0x8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x1015_af1c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_af1f, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_af22, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1015_af29, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1015_af30, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1015_af33, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1015_af36, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1015_af39, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1015_af3c, 4); mov(memw[ss, ebp - 0x24], ax);          /* mov [ebp-0x24], ax */
            ii(0x1015_af40, 5); mov(ebx, 0x101b_74b4);                  /* mov ebx, 0x101b74b4 */
            ii(0x1015_af45, 3); mov(edx, memd[ss, ebp - 0x26]);         /* mov edx, [ebp-0x26] */
            ii(0x1015_af48, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_af4b, 3); mov(eax, memd[ss, ebp - 0x26]);         /* mov eax, [ebp-0x26] */
            ii(0x1015_af4e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_af51, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_af54, 5); call(Definitions.sys_new_arr, 0xb0b7);  /* call 0x10166010 */
            ii(0x1015_af59, 5); call(Definitions.sys_call_ctor_arr_v2, 0xb012); /* call 0x10165f70 */
            ii(0x1015_af5e, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1015_af61, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1015_af65, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_af68, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_af6a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_af6d, 3); add(edx, 0x2);                          /* add edx, 0x2 */
            ii(0x1015_af70, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1015_af72, 7); mov(memd[ss, ebp - 0x2c], 0);           /* mov dword [ebp-0x2c], 0x0 */
            ii(0x1015_af79, 2); jmp(0x1015_af81, 0x6); goto l_0x1015_af81; /* jmp 0x1015af81 */
        l_0x1015_af7b:
            ii(0x1015_af7b, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1015_af7e, 3); inc(memd[ss, ebp - 0x2c]);              /* inc dword [ebp-0x2c] */
        l_0x1015_af81:
            ii(0x1015_af81, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1015_af84, 4); cmp(ax, memw[ss, ebp - 0x20]);          /* cmp ax, [ebp-0x20] */
            ii(0x1015_af88, 6); if(jge(0x1015_b145, 0x1b7)) goto l_0x1015_b145; /* jge 0x1015b145 */
            ii(0x1015_af8e, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_af92, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_af95, 3); add(eax, memd[ss, ebp - 0x14]);         /* add eax, [ebp-0x14] */
            ii(0x1015_af98, 3); mov(eax, memd[ds, eax + 0x2]);          /* mov eax, [eax+0x2] */
            ii(0x1015_af9b, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1015_af9e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_afa1, 3); add(eax, memd[ss, ebp - 0x30]);         /* add eax, [ebp-0x30] */
            ii(0x1015_afa4, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1015_afa7, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1015_afaa, 4); imul(ax, memw[ds, eax], 0x3);           /* imul ax, [eax], 0x3 */
            ii(0x1015_afae, 1); inc(eax);                               /* inc eax */
            ii(0x1015_afaf, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1015_afb2, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1015_afb5, 4); cmp(ax, memw[ss, ebp - 0x1c]);          /* cmp ax, [ebp-0x1c] */
            ii(0x1015_afb9, 2); if(jle(0x1015_afdb, 0x20)) goto l_0x1015_afdb; /* jle 0x1015afdb */
            ii(0x1015_afbb, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1015_afbe, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1015_afc1, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1015_afc5, 2); if(jz(0x1015_afcf, 0x8)) goto l_0x1015_afcf; /* jz 0x1015afcf */
            ii(0x1015_afc7, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_afca, 5); call(Definitions.sys_delete, 0xaf95);   /* call 0x10165f64 */
        l_0x1015_afcf:
            ii(0x1015_afcf, 4); movsx(eax, memw[ss, ebp - 0x38]);       /* movsx eax, word [ebp-0x38] */
            ii(0x1015_afd3, 5); call(Definitions.sys_new_arr, 0xb038);  /* call 0x10166010 */
            ii(0x1015_afd8, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x1015_afdb:
            ii(0x1015_afdb, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1015_afde, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1015_afe1, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1015_afe5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_afe7, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1015_afeb, 3); lea(edx, eax - 0x1);                    /* lea edx, [eax-0x1] */
            ii(0x1015_afee, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_aff0, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_aff3, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_aff5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_aff7, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_affb, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_affe, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b001, 3); mov(memw[ds, eax], dx);                 /* mov [eax], dx */
            ii(0x1015_b004, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1015_b007, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1015_b009, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_b00c, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1015_b010, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_b012, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1015_b016, 3); lea(edx, eax - 0x1);                    /* lea edx, [eax-0x1] */
            ii(0x1015_b019, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_b01b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_b01e, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_b020, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_b022, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b026, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b029, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b02c, 4); mov(memw[ds, eax + 0x2], dx);           /* mov [eax+0x2], dx */
            ii(0x1015_b030, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x1015_b033, 3); mov(edx, memd[ds, edx + 0x2]);          /* mov edx, [edx+0x2] */
            ii(0x1015_b036, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_b039, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1015_b03d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_b03f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_b042, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_b044, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_b046, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b04a, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b04d, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b050, 4); mov(memw[ds, eax + 0x4], dx);           /* mov [eax+0x4], dx */
            ii(0x1015_b054, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x1015_b057, 3); mov(edx, memd[ds, edx + 0x4]);          /* mov edx, [edx+0x4] */
            ii(0x1015_b05a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_b05d, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1015_b061, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_b063, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_b066, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_b068, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_b06a, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b06e, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b071, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b074, 4); mov(memw[ds, eax + 0x6], dx);           /* mov [eax+0x6], dx */
            ii(0x1015_b078, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b07c, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b07f, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b082, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1015_b084, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_b087, 3); imul(eax, eax, 0x6);                    /* imul eax, eax, 0x6 */
            ii(0x1015_b08a, 5); call(Definitions.sys_new_arr, 0xaf81);  /* call 0x10166010 */
            ii(0x1015_b08f, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1015_b093, 3); imul(edx, edx, 0xc);                    /* imul edx, edx, 0xc */
            ii(0x1015_b096, 3); add(edx, memd[ss, ebp - 0x28]);         /* add edx, [ebp-0x28] */
            ii(0x1015_b099, 3); mov(memd[ds, edx + 0x8], eax);          /* mov [edx+0x8], eax */
            ii(0x1015_b09c, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b0a0, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b0a3, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b0a6, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1015_b0a8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_b0ab, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_b0ae, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1015_b0b1, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1015_b0b4, 2); add(memd[ds, edx], eax);                /* add [edx], eax */
            ii(0x1015_b0b6, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1015_b0b9, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1015_b0bc, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1015_b0bf, 7); mov(memd[ss, ebp - 0x40], 0);           /* mov dword [ebp-0x40], 0x0 */
            ii(0x1015_b0c6, 2); jmp(0x1015_b0ce, 0x6); goto l_0x1015_b0ce; /* jmp 0x1015b0ce */
        l_0x1015_b0c8:
            ii(0x1015_b0c8, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1015_b0cb, 3); inc(memd[ss, ebp - 0x40]);              /* inc dword [ebp-0x40] */
        l_0x1015_b0ce:
            ii(0x1015_b0ce, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1015_b0d2, 3); imul(edx, edx, 0xc);                    /* imul edx, edx, 0xc */
            ii(0x1015_b0d5, 3); add(edx, memd[ss, ebp - 0x28]);         /* add edx, [ebp-0x28] */
            ii(0x1015_b0d8, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1015_b0db, 4); cmp(ax, memw[ds, edx + 0x2]);           /* cmp ax, [edx+0x2] */
            ii(0x1015_b0df, 2); if(jge(0x1015_b140, 0x5f)) goto l_0x1015_b140; /* jge 0x1015b140 */
            ii(0x1015_b0e1, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1015_b0e5, 1); push(eax);                              /* push eax */
            ii(0x1015_b0e6, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_b0e8, 3); mov(cl, memb[ss, ebp - 0x4]);           /* mov cl, [ebp-0x4] */
            ii(0x1015_b0eb, 3); mov(ebx, memd[ss, ebp - 0x18]);         /* mov ebx, [ebp-0x18] */
            ii(0x1015_b0ee, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b0f2, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b0f5, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b0f8, 4); movsx(edx, memw[ss, ebp - 0x40]);       /* movsx edx, word [ebp-0x40] */
            ii(0x1015_b0fc, 3); imul(edx, edx, 0x6);                    /* imul edx, edx, 0x6 */
            ii(0x1015_b0ff, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x1015_b102, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_b104, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1015_b107, 3); mov(esi, memd[ss, ebp - 0x10]);         /* mov esi, [ebp-0x10] */
            ii(0x1015_b10a, 2); add(esi, memd[ds, eax]);                /* add esi, [eax] */
            ii(0x1015_b10c, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1015_b10e, 5); call(0x1015_ad43, -0x3d0);              /* call 0x1015ad43 */
            ii(0x1015_b113, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b117, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b11a, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b11d, 4); movsx(edx, memw[ss, ebp - 0x40]);       /* movsx edx, word [ebp-0x40] */
            ii(0x1015_b121, 3); imul(edx, edx, 0x6);                    /* imul edx, edx, 0x6 */
            ii(0x1015_b124, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x1015_b127, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_b129, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x1015_b12c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_b12f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_b132, 2); add(memd[ds, eax], edx);                /* add [eax], edx */
            ii(0x1015_b134, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1015_b138, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_b13b, 3); add(memd[ss, ebp - 0x3c], eax);         /* add [ebp-0x3c], eax */
            ii(0x1015_b13e, 2); jmp(0x1015_b0c8, -0x78); goto l_0x1015_b0c8; /* jmp 0x1015b0c8 */
        l_0x1015_b140:
            ii(0x1015_b140, 5); jmp(0x1015_af7b, -0x1ca); goto l_0x1015_af7b; /* jmp 0x1015af7b */
        l_0x1015_b145:
            ii(0x1015_b145, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1015_b149, 2); if(jz(0x1015_b153, 0x8)) goto l_0x1015_b153; /* jz 0x1015b153 */
            ii(0x1015_b14b, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1015_b14e, 5); call(Definitions.sys_delete, 0xae11);   /* call 0x10165f64 */
        l_0x1015_b153:
            ii(0x1015_b153, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_b156, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1015_b158, 5); call(Definitions.sys_new_arr, 0xaeb3);  /* call 0x10166010 */
            ii(0x1015_b15d, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1015_b160, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1015_b163, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_b166, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1015_b169, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1015_b16c, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1015_b16f, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1015_b173, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_b176, 3); mov(edx, memd[ss, ebp - 0x44]);         /* mov edx, [ebp-0x44] */
            ii(0x1015_b179, 3); add(edx, 0x2);                          /* add edx, 0x2 */
            ii(0x1015_b17c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_b17e, 3); mov(memd[ss, ebp - 0x48], edx);         /* mov [ebp-0x48], edx */
            ii(0x1015_b181, 7); mov(memd[ss, ebp - 0x2c], 0);           /* mov dword [ebp-0x2c], 0x0 */
            ii(0x1015_b188, 2); jmp(0x1015_b190, 0x6); goto l_0x1015_b190; /* jmp 0x1015b190 */
        l_0x1015_b18a:
            ii(0x1015_b18a, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1015_b18d, 3); inc(memd[ss, ebp - 0x2c]);              /* inc dword [ebp-0x2c] */
        l_0x1015_b190:
            ii(0x1015_b190, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1015_b193, 4); cmp(ax, memw[ss, ebp - 0x20]);          /* cmp ax, [ebp-0x20] */
            ii(0x1015_b197, 6); if(jge(0x1015_b2f0, 0x153)) goto l_0x1015_b2f0; /* jge 0x1015b2f0 */
            ii(0x1015_b19d, 3); mov(edx, memd[ss, ebp - 0x48]);         /* mov edx, [ebp-0x48] */
            ii(0x1015_b1a0, 3); sub(edx, memd[ss, ebp - 0x44]);         /* sub edx, [ebp-0x44] */
            ii(0x1015_b1a3, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b1a7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_b1aa, 3); add(eax, memd[ss, ebp - 0x14]);         /* add eax, [ebp-0x14] */
            ii(0x1015_b1ad, 3); mov(memd[ds, eax + 0x2], edx);          /* mov [eax+0x2], edx */
            ii(0x1015_b1b0, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1015_b1b3, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1015_b1b6, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b1ba, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b1bd, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b1c0, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x1015_b1c3, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1015_b1c6, 3); mov(memw[ds, eax], dx);                 /* mov [eax], dx */
            ii(0x1015_b1c9, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b1cd, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b1d0, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b1d3, 4); mov(dx, memw[ds, eax + 0x2]);           /* mov dx, [eax+0x2] */
            ii(0x1015_b1d7, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1015_b1da, 4); mov(memw[ds, eax + 0x2], dx);           /* mov [eax+0x2], dx */
            ii(0x1015_b1de, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b1e2, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b1e5, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b1e8, 4); mov(dx, memw[ds, eax + 0x4]);           /* mov dx, [eax+0x4] */
            ii(0x1015_b1ec, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1015_b1ef, 4); mov(memw[ds, eax + 0x4], dx);           /* mov [eax+0x4], dx */
            ii(0x1015_b1f3, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b1f7, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b1fa, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b1fd, 4); mov(dx, memw[ds, eax + 0x6]);           /* mov dx, [eax+0x6] */
            ii(0x1015_b201, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1015_b204, 4); mov(memw[ds, eax + 0x6], dx);           /* mov [eax+0x6], dx */
            ii(0x1015_b208, 4); add(memd[ss, ebp - 0x48], 0x8);         /* add dword [ebp-0x48], 0x8 */
            ii(0x1015_b20c, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1015_b20f, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1015_b212, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b216, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b219, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b21c, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1015_b21e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_b221, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_b224, 3); add(memd[ss, ebp - 0x48], eax);         /* add [ebp-0x48], eax */
            ii(0x1015_b227, 7); mov(memd[ss, ebp - 0x40], 0);           /* mov dword [ebp-0x40], 0x0 */
            ii(0x1015_b22e, 2); jmp(0x1015_b236, 0x6); goto l_0x1015_b236; /* jmp 0x1015b236 */
        l_0x1015_b230:
            ii(0x1015_b230, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1015_b233, 3); inc(memd[ss, ebp - 0x40]);              /* inc dword [ebp-0x40] */
        l_0x1015_b236:
            ii(0x1015_b236, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1015_b23a, 3); imul(edx, edx, 0xc);                    /* imul edx, edx, 0xc */
            ii(0x1015_b23d, 3); add(edx, memd[ss, ebp - 0x28]);         /* add edx, [ebp-0x28] */
            ii(0x1015_b240, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1015_b243, 4); cmp(ax, memw[ds, edx + 0x2]);           /* cmp ax, [edx+0x2] */
            ii(0x1015_b247, 6); if(jge(0x1015_b2d9, 0x8c)) goto l_0x1015_b2d9; /* jge 0x1015b2d9 */
            ii(0x1015_b24d, 3); mov(edx, memd[ss, ebp - 0x48]);         /* mov edx, [ebp-0x48] */
            ii(0x1015_b250, 3); sub(edx, memd[ss, ebp - 0x44]);         /* sub edx, [ebp-0x44] */
            ii(0x1015_b253, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1015_b256, 4); add(memd[ss, ebp - 0x3c], 0x4);         /* add dword [ebp-0x3c], 0x4 */
            ii(0x1015_b25a, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1015_b25c, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b260, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b263, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b266, 4); movsx(edx, memw[ss, ebp - 0x40]);       /* movsx edx, word [ebp-0x40] */
            ii(0x1015_b26a, 3); imul(edx, edx, 0x6);                    /* imul edx, edx, 0x6 */
            ii(0x1015_b26d, 3); mov(ebx, memd[ds, eax + 0x8]);          /* mov ebx, [eax+0x8] */
            ii(0x1015_b270, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1015_b272, 3); mov(ebx, memd[ds, ebx + 0x2]);          /* mov ebx, [ebx+0x2] */
            ii(0x1015_b275, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_b278, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b27c, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b27f, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b282, 4); movsx(edx, memw[ss, ebp - 0x40]);       /* movsx edx, word [ebp-0x40] */
            ii(0x1015_b286, 3); imul(ecx, edx, 0x6);                    /* imul ecx, edx, 0x6 */
            ii(0x1015_b289, 3); mov(edx, memd[ds, eax + 0x8]);          /* mov edx, [eax+0x8] */
            ii(0x1015_b28c, 2); add(edx, ecx);                          /* add edx, ecx */
            ii(0x1015_b28e, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1015_b290, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1015_b293, 5); call(Definitions.sys_memcpy, 0xabb3);   /* call 0x10165e4b */
            ii(0x1015_b298, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b29c, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b29f, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b2a2, 4); movsx(edx, memw[ss, ebp - 0x40]);       /* movsx edx, word [ebp-0x40] */
            ii(0x1015_b2a6, 3); imul(edx, edx, 0x6);                    /* imul edx, edx, 0x6 */
            ii(0x1015_b2a9, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x1015_b2ac, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_b2ae, 3); mov(eax, memd[ds, eax + 0x2]);          /* mov eax, [eax+0x2] */
            ii(0x1015_b2b1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_b2b4, 3); add(memd[ss, ebp - 0x48], eax);         /* add [ebp-0x48], eax */
            ii(0x1015_b2b7, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b2bb, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b2be, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b2c1, 4); movsx(edx, memw[ss, ebp - 0x40]);       /* movsx edx, word [ebp-0x40] */
            ii(0x1015_b2c5, 3); imul(edx, edx, 0x6);                    /* imul edx, edx, 0x6 */
            ii(0x1015_b2c8, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x1015_b2cb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_b2cd, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1015_b2cf, 5); call(Definitions.sys_delete, 0xac90);   /* call 0x10165f64 */
            ii(0x1015_b2d4, 5); jmp(0x1015_b230, -0xa9); goto l_0x1015_b230; /* jmp 0x1015b230 */
        l_0x1015_b2d9:
            ii(0x1015_b2d9, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1015_b2dd, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1015_b2e0, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1015_b2e3, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x1015_b2e6, 5); call(Definitions.sys_delete, 0xac79);   /* call 0x10165f64 */
            ii(0x1015_b2eb, 5); jmp(0x1015_b18a, -0x166); goto l_0x1015_b18a; /* jmp 0x1015b18a */
        l_0x1015_b2f0:
            ii(0x1015_b2f0, 3); mov(edx, memd[ss, ebp - 0x48]);         /* mov edx, [ebp-0x48] */
            ii(0x1015_b2f3, 3); sub(edx, memd[ss, ebp - 0x44]);         /* sub edx, [ebp-0x44] */
            ii(0x1015_b2f6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_b2f9, 2); cmp(edx, memd[ds, eax]);                /* cmp edx, [eax] */
            ii(0x1015_b2fb, 2); if(jnz(0x1015_b306, 0x9)) goto l_0x1015_b306; /* jnz 0x1015b306 */
            ii(0x1015_b2fd, 7); mov(memd[ss, ebp - 0x4c], 0);           /* mov dword [ebp-0x4c], 0x0 */
            ii(0x1015_b304, 2); jmp(0x1015_b31f, 0x19); goto l_0x1015_b31f; /* jmp 0x1015b31f */
        l_0x1015_b306:
            ii(0x1015_b306, 5); mov(ecx, 0xf51);                        /* mov ecx, 0xf51 */
            ii(0x1015_b30b, 5); mov(ebx, StringDefinitions.UnitsmgrCpp2); /* mov ebx, 0x101b275f */
            ii(0x1015_b310, 5); mov(edx, StringDefinitions.TotalSizeEqualDestResult); /* mov edx, 0x101b276c */
            ii(0x1015_b315, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_b317, 5); call(Definitions.sys_assert, 0xaa76);   /* call 0x10165d92 */
            ii(0x1015_b31c, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
        l_0x1015_b31f:
            ii(0x1015_b31f, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1015_b322, 5); call(Definitions.sys_delete, 0xac3d);   /* call 0x10165f64 */
            ii(0x1015_b327, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1015_b32a, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1015_b32d, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x1015_b330, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_b332, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_b333, 1); pop(edi);                               /* pop edi */
            ii(0x1015_b334, 1); pop(esi);                               /* pop esi */
            ii(0x1015_b335, 1); ret();                                  /* ret */
        }
    }
}
