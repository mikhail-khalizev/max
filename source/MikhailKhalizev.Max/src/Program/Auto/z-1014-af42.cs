using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_af42-c5efce62")]
        public void Method_1014_af42()
        {
            ii(0x1014_af42, 5); push(0x7c);                             /* push 0x7c */
            ii(0x1014_af47, 5); call(Definitions.sys_check_available_stack_size, 0x1_ae06); /* call 0x10165d52 */
            ii(0x1014_af4c, 1); push(ebx);                              /* push ebx */
            ii(0x1014_af4d, 1); push(ecx);                              /* push ecx */
            ii(0x1014_af4e, 1); push(edx);                              /* push edx */
            ii(0x1014_af4f, 1); push(esi);                              /* push esi */
            ii(0x1014_af50, 1); push(edi);                              /* push edi */
            ii(0x1014_af51, 1); push(ebp);                              /* push ebp */
            ii(0x1014_af52, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_af54, 6); sub(esp, 0x5c);                         /* sub esp, 0x5c */
            ii(0x1014_af5a, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_af5d, 4); or(memb[ss, ebp - 0xc], 1);             /* or byte [ebp-0xc], 0x1 */
            ii(0x1014_af61, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1014_af64, 5); call(Definitions.my_ctor_0x101b_38f8, -0xd_4879); /* call 0x100766f0 */
            ii(0x1014_af69, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_af6c, 4); and(memb[ss, ebp - 0xc], -2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
        l_0x1014_af70:
            ii(0x1014_af70, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_af73, 6); mov(eax, memd[ds, eax + 0xa1]);         /* mov eax, [eax+0xa1] */
            ii(0x1014_af79, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_af7c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_af7e, 2); if(jle(0x1014_af8f, 0xf)) goto l_0x1014_af8f; /* jle 0x1014af8f */
            ii(0x1014_af80, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_af82, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1014_af85, 5); call(0x1007_5f2c, -0xd_505e);           /* call 0x10075f2c */
            ii(0x1014_af8a, 5); jmp(0x1014_b5e6, 0x657); goto l_0x1014_b5e6; /* jmp 0x1014b5e6 */
        l_0x1014_af8f:
            ii(0x1014_af8f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_af92, 5); call(0x1014_9fa8, -0xfef);              /* call 0x10149fa8 */
            ii(0x1014_af97, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_af9a, 3); mov(dl, memb[ds, eax + 0x2b]);          /* mov dl, [eax+0x2b] */
            ii(0x1014_af9d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_afa0, 3); cmp(dl, memb[ds, eax + 0x2a]);          /* cmp dl, [eax+0x2a] */
            ii(0x1014_afa3, 2); if(jae(0x1014_afd9, 0x34)) goto l_0x1014_afd9; /* jae 0x1014afd9 */
            ii(0x1014_afa5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_afa8, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1014_afab, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_afae, 7); cmp(memb[ds, 0x101c_37ca], 0);          /* cmp byte [0x101c37ca], 0x0 */
            ii(0x1014_afb5, 2); if(jz(0x1014_afc0, 9)) goto l_0x1014_afc0; /* jz 0x1014afc0 */
            ii(0x1014_afb7, 7); mov(memd[ss, ebp - 0x1c], 2);           /* mov dword [ebp-0x1c], 0x2 */
            ii(0x1014_afbe, 2); jmp(0x1014_afc7, 7); goto l_0x1014_afc7; /* jmp 0x1014afc7 */
        l_0x1014_afc0:
            ii(0x1014_afc0, 7); mov(memd[ss, ebp - 0x1c], 1);           /* mov dword [ebp-0x1c], 0x1 */
        l_0x1014_afc7:
            ii(0x1014_afc7, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1014_afca, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1014_afcc, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_afd1, 3); add(eax, memd[ss, ebp - 0x1c]);         /* add eax, [ebp-0x1c] */
            ii(0x1014_afd4, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1014_afd7, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
        l_0x1014_afd9:
            ii(0x1014_afd9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_afdc, 3); mov(dl, memb[ds, eax + 0x2b]);          /* mov dl, [eax+0x2b] */
            ii(0x1014_afdf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_afe2, 3); cmp(dl, memb[ds, eax + 0x2a]);          /* cmp dl, [eax+0x2a] */
            ii(0x1014_afe5, 2); if(jbe(0x1014_aff3, 0xc)) goto l_0x1014_aff3; /* jbe 0x1014aff3 */
            ii(0x1014_afe7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_afea, 3); mov(dl, memb[ds, eax + 0x2a]);          /* mov dl, [eax+0x2a] */
            ii(0x1014_afed, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_aff0, 3); mov(memb[ds, eax + 0x2b], dl);          /* mov [eax+0x2b], dl */
        l_0x1014_aff3:
            ii(0x1014_aff3, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1014_aff8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_affb, 5); call(0x1007_6d98, -0xd_4268);           /* call 0x10076d98 */
            ii(0x1014_b000, 2); test(al, al);                           /* test al, al */
            ii(0x1014_b002, 6); if(jz(0x1014_b090, 0x88)) goto l_0x1014_b090; /* jz 0x1014b090 */
            ii(0x1014_b008, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b00b, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1014_b00e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_b013, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_b015, 2); if(jz(0x1014_b036, 0x1f)) goto l_0x1014_b036; /* jz 0x1014b036 */
            ii(0x1014_b017, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b01a, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_b01d, 5); call(0x1007_69d8, -0xd_464a);           /* call 0x100769d8 */
            ii(0x1014_b022, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1014_b025, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1014_b028, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1014_b02b, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1014_b02e, 3); call_abs(memd[ds, edx + 0x38]);         /* call dword [edx+0x38] */
            ii(0x1014_b031, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1014_b034, 2); if(jnz(0x1014_b053, 0x1d)) goto l_0x1014_b053; /* jnz 0x1014b053 */
        l_0x1014_b036:
            ii(0x1014_b036, 5); call(0x1010_2bf8, -0x4_8443);           /* call 0x10102bf8 */
            ii(0x1014_b03b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1014_b03d, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1014_b03f, 5); mov(ebx, 5);                            /* mov ebx, 0x5 */
            ii(0x1014_b044, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_b047, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1014_b04c, 5); call(0x1013_d5c0, -0xda91);             /* call 0x1013d5c0 */
            ii(0x1014_b051, 2); jmp(0x1014_b090, 0x3d); goto l_0x1014_b090; /* jmp 0x1014b090 */
        l_0x1014_b053:
            ii(0x1014_b053, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b056, 3); mov(al, memb[ds, eax + 0x2c]);          /* mov al, [eax+0x2c] */
            ii(0x1014_b059, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_b05e, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1014_b061, 2); if(jz(0x1014_b073, 0x10)) goto l_0x1014_b073; /* jz 0x1014b073 */
            ii(0x1014_b063, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b066, 3); mov(al, memb[ds, eax + 0x2c]);          /* mov al, [eax+0x2c] */
            ii(0x1014_b069, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_b06e, 3); cmp(eax, 5);                            /* cmp eax, 0x5 */
            ii(0x1014_b071, 2); if(jnz(0x1014_b075, 2)) goto l_0x1014_b075; /* jnz 0x1014b075 */
        l_0x1014_b073:
            ii(0x1014_b073, 2); jmp(0x1014_b090, 0x1b); goto l_0x1014_b090; /* jmp 0x1014b090 */
        l_0x1014_b075:
            ii(0x1014_b075, 5); call(0x1010_2bf8, -0x4_8482);           /* call 0x10102bf8 */
            ii(0x1014_b07a, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1014_b07c, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1014_b07e, 5); mov(ebx, 3);                            /* mov ebx, 0x3 */
            ii(0x1014_b083, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_b086, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1014_b08b, 5); call(0x1013_d5c0, -0xdad0);             /* call 0x1013d5c0 */
        l_0x1014_b090:
            ii(0x1014_b090, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_b092, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_b095, 3); mov(al, memb[ds, edx + 0x2b]);          /* mov al, [edx+0x2b] */
            ii(0x1014_b098, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1014_b09b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b09e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b0a0, 3); mov(dl, memb[ds, eax + 0x5e]);          /* mov dl, [eax+0x5e] */
            ii(0x1014_b0a3, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1014_b0a7, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_b0a9, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1014_b0ad, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1014_b0af, 5); mov(ebx, 0x40);                         /* mov ebx, 0x40 */
            ii(0x1014_b0b4, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1014_b0b6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_b0b8, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_b0ba, 6); if(jl(0x1014_b13d, 0x7d)) goto l_0x1014_b13d; /* jl 0x1014b13d */
            ii(0x1014_b0c0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b0c3, 3); mov(al, memb[ds, eax + 0x5e]);          /* mov al, [eax+0x5e] */
            ii(0x1014_b0c6, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_b0c8, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x1014_b0cd, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_b0cf, 3); mov(memd[ss, ebp - 0x24], edx);         /* mov [ebp-0x24], edx */
            ii(0x1014_b0d2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b0d5, 5); cmp(memw[ds, eax + 8], 0x42);           /* cmp word [eax+0x8], 0x42 */
            ii(0x1014_b0da, 2); if(jz(0x1014_b0e6, 0xa)) goto l_0x1014_b0e6; /* jz 0x1014b0e6 */
            ii(0x1014_b0dc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b0df, 5); cmp(memw[ds, eax + 8], 0x43);           /* cmp word [eax+0x8], 0x43 */
            ii(0x1014_b0e4, 2); if(jnz(0x1014_b0e8, 2)) goto l_0x1014_b0e8; /* jnz 0x1014b0e8 */
        l_0x1014_b0e6:
            ii(0x1014_b0e6, 2); jmp(0x1014_b13d, 0x55); goto l_0x1014_b13d; /* jmp 0x1014b13d */
        l_0x1014_b0e8:
            ii(0x1014_b0e8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b0eb, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1014_b0ee, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_b0f3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_b0f5, 2); if(jz(0x1014_b116, 0x1f)) goto l_0x1014_b116; /* jz 0x1014b116 */
            ii(0x1014_b0f7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b0fa, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_b0fd, 5); call(0x1007_69d8, -0xd_472a);           /* call 0x100769d8 */
            ii(0x1014_b102, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1014_b105, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1014_b108, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1014_b10b, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1014_b10e, 3); call_abs(memd[ds, edx + 0x38]);         /* call dword [edx+0x38] */
            ii(0x1014_b111, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1014_b114, 2); if(jnz(0x1014_b13d, 0x27)) goto l_0x1014_b13d; /* jnz 0x1014b13d */
        l_0x1014_b116:
            ii(0x1014_b116, 4); sar(memw[ss, ebp - 0x24], 1);           /* sar word [ebp-0x24], 1 */
            ii(0x1014_b11a, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1014_b11e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_b120, 2); if(jnz(0x1014_b128, 6)) goto l_0x1014_b128; /* jnz 0x1014b128 */
            ii(0x1014_b122, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1014_b125, 3); inc(memd[ss, ebp - 0x24]);              /* inc dword [ebp-0x24] */
        l_0x1014_b128:
            ii(0x1014_b128, 3); mov(al, memb[ss, ebp - 0x24]);          /* mov al, [ebp-0x24] */
            ii(0x1014_b12b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_b12e, 3); mov(memb[ds, edx + 0x2b], al);          /* mov [edx+0x2b], al */
            ii(0x1014_b131, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b134, 3); mov(dl, memb[ds, eax + 0x2b]);          /* mov dl, [eax+0x2b] */
            ii(0x1014_b137, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b13a, 3); mov(memb[ds, eax + 0x2a], dl);          /* mov [eax+0x2a], dl */
        l_0x1014_b13d:
            ii(0x1014_b13d, 3); mov(al, memb[ss, ebp - 0x24]);          /* mov al, [ebp-0x24] */
            ii(0x1014_b140, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_b143, 3); add(memb[ds, edx + 0x5e], al);          /* add [edx+0x5e], al */
            ii(0x1014_b146, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_b149, 3); mov(dl, memb[ds, edx + 0x29]);          /* mov dl, [edx+0x29] */
            ii(0x1014_b14c, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1014_b152, 8); movsx(ax, memb[ds, edx + 0x101b_d914]); /* movsx ax, byte [edx+0x101bd914] */
            ii(0x1014_b15a, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1014_b15d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_b160, 3); mov(dl, memb[ds, edx + 0x29]);          /* mov dl, [edx+0x29] */
            ii(0x1014_b163, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1014_b169, 8); movsx(ax, memb[ds, edx + 0x101b_d91c]); /* movsx ax, byte [edx+0x101bd91c] */
            ii(0x1014_b171, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1014_b174, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1014_b177, 4); imul(eax, memd[ss, ebp - 0x24]);        /* imul eax, [ebp-0x24] */
            ii(0x1014_b17b, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1014_b17e, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1014_b181, 4); imul(eax, memd[ss, ebp - 0x24]);        /* imul eax, [ebp-0x24] */
            ii(0x1014_b185, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1014_b188, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1014_b18c, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1014_b190, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1014_b192, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_b195, 3); mov(edx, memd[ds, edx + 0x14]);         /* mov edx, [edx+0x14] */
            ii(0x1014_b198, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_b19b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_b19d, 3); sar(eax, 6);                            /* sar eax, 0x6 */
            ii(0x1014_b1a0, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_b1a2, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_b1a5, 3); mov(eax, memd[ds, edx + 0x18]);         /* mov eax, [edx+0x18] */
            ii(0x1014_b1a8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_b1ab, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1014_b1ad, 3); mov(memd[ss, ebp - 0x3c], ebx);         /* mov [ebp-0x3c], ebx */
            ii(0x1014_b1b0, 4); movsx(edx, memw[ss, ebp - 0x38]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1014_b1b4, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1014_b1b8, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_b1ba, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_b1bc, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_b1bf, 3); mov(edx, memd[ds, edx + 0x16]);         /* mov edx, [edx+0x16] */
            ii(0x1014_b1c2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_b1c5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_b1c7, 3); sar(eax, 6);                            /* sar eax, 0x6 */
            ii(0x1014_b1ca, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1014_b1cc, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_b1cf, 3); mov(eax, memd[ds, edx + 0x1a]);         /* mov eax, [edx+0x1a] */
            ii(0x1014_b1d2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_b1d5, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1014_b1d7, 3); mov(memd[ss, ebp - 0x40], ebx);         /* mov [ebp-0x40], ebx */
            ii(0x1014_b1da, 4); movsx(edx, memw[ss, ebp - 0x3c]);       /* movsx edx, word [ebp-0x3c] */
            ii(0x1014_b1de, 4); movsx(eax, memw[ss, ebp - 0x40]);       /* movsx eax, word [ebp-0x40] */
            ii(0x1014_b1e2, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1014_b1e4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_b1e6, 2); if(jz(0x1014_b21e, 0x36)) goto l_0x1014_b21e; /* jz 0x1014b21e */
            ii(0x1014_b1e8, 3); lea(edx, memd[ss, ebp - 0x44]);         /* lea edx, [ebp-0x44] */
            ii(0x1014_b1eb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b1ee, 5); call(0x1014_edfa, 0x3c07);              /* call 0x1014edfa */
            ii(0x1014_b1f3, 3); lea(ebx, memd[ss, ebp - 0x14]);         /* lea ebx, [ebp-0x14] */
            ii(0x1014_b1f6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_b1f8, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_b1fa, 5); call(0x1008_ac18, -0xc_05e7);           /* call 0x1008ac18 */
            ii(0x1014_b1ff, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b201, 3); lea(eax, memd[ss, ebp - 0x44]);         /* lea eax, [ebp-0x44] */
            ii(0x1014_b204, 5); call(0x1007_5f2c, -0xd_52dd);           /* call 0x10075f2c */
            ii(0x1014_b209, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_b20c, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1014_b211, 5); call(0x1010_3752, -0x4_7ac4);           /* call 0x10103752 */
            ii(0x1014_b216, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b219, 5); call(0x1015_50e0, 0x9ec2);              /* call 0x101550e0 */
        l_0x1014_b21e:
            ii(0x1014_b21e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_b220, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1014_b225, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1014_b228, 6); mov(al, memb[ds, eax + 0xab]);          /* mov al, [eax+0xab] */
            ii(0x1014_b22e, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1014_b231, 4); movsx(ebx, memw[ss, ebp - 0x38]);       /* movsx ebx, word [ebp-0x38] */
            ii(0x1014_b235, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1014_b239, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b23c, 5); call(0x1014_9c2f, -0x1612);             /* call 0x10149c2f */
            ii(0x1014_b241, 4); movsx(edx, memw[ss, ebp - 0x3c]);       /* movsx edx, word [ebp-0x3c] */
            ii(0x1014_b245, 4); movsx(eax, memw[ss, ebp - 0x40]);       /* movsx eax, word [ebp-0x40] */
            ii(0x1014_b249, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1014_b24b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_b24d, 6); if(jz(0x1014_b2ff, 0xac)) goto l_0x1014_b2ff; /* jz 0x1014b2ff */
            ii(0x1014_b253, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b256, 3); mov(eax, memd[ds, eax + 0x14]);         /* mov eax, [eax+0x14] */
            ii(0x1014_b259, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_b25c, 3); sar(eax, 6);                            /* sar eax, 0x6 */
            ii(0x1014_b25f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_b261, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b264, 4); mov(memw[ds, eax + 0x1a], dx);          /* mov [eax+0x1a], dx */
            ii(0x1014_b268, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b26b, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1014_b26e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_b271, 3); sar(eax, 6);                            /* sar eax, 0x6 */
            ii(0x1014_b274, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_b276, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b279, 4); mov(memw[ds, eax + 0x1c], dx);          /* mov [eax+0x1c], dx */
            ii(0x1014_b27d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b27f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b282, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_b285, 5); call(0x1013_ad71, -0x1_0519);           /* call 0x1013ad71 */
            ii(0x1014_b28a, 2); test(al, al);                           /* test al, al */
            ii(0x1014_b28c, 2); if(jz(0x1014_b2e3, 0x55)) goto l_0x1014_b2e3; /* jz 0x1014b2e3 */
            ii(0x1014_b28e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b291, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_b294, 5); call(0x1015_53e0, 0xa147);              /* call 0x101553e0 */
            ii(0x1014_b299, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x1014_b29c, 3); lea(edx, memd[ss, ebp - 0x4c]);         /* lea edx, [ebp-0x4c] */
            ii(0x1014_b29f, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1014_b2a2, 5); call(0x100b_8204, -0x9_30a3);           /* call 0x100b8204 */
            ii(0x1014_b2a7, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1014_b2aa, 5); call(0x1015_537c, 0xa0cd);              /* call 0x1015537c */
            ii(0x1014_b2af, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1014_b2b2, 4); movsx(edx, memw[ss, ebp - 0x50]);       /* movsx edx, word [ebp-0x50] */
            ii(0x1014_b2b6, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1014_b2b9, 5); call(0x100b_827c, -0x9_3042);           /* call 0x100b827c */
            ii(0x1014_b2be, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_b2c0, 3); mov(al, memb[ss, ebp - 0x3c]);          /* mov al, [ebp-0x3c] */
            ii(0x1014_b2c3, 2); sub(memb[ds, edx], al);                 /* sub [edx], al */
            ii(0x1014_b2c5, 4); movsx(edx, memw[ss, ebp - 0x50]);       /* movsx edx, word [ebp-0x50] */
            ii(0x1014_b2c9, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1014_b2cc, 5); call(0x100b_827c, -0x9_3055);           /* call 0x100b827c */
            ii(0x1014_b2d1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_b2d3, 3); mov(al, memb[ss, ebp - 0x40]);          /* mov al, [ebp-0x40] */
            ii(0x1014_b2d6, 3); sub(memb[ds, edx + 1], al);             /* sub [edx+0x1], al */
            ii(0x1014_b2d9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b2db, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1014_b2de, 5); call(0x100b_7294, -0x9_404f);           /* call 0x100b7294 */
        l_0x1014_b2e3:
            ii(0x1014_b2e3, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1014_b2e8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b2eb, 5); call(0x1007_1838, -0xd_9ab8);           /* call 0x10071838 */
            ii(0x1014_b2f0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b2f2, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1014_b2f5, 5); call(0x1007_6600, -0xd_4cfa);           /* call 0x10076600 */
            ii(0x1014_b2fa, 5); call(0x1007_1838, -0xd_9ac7);           /* call 0x10071838 */
        l_0x1014_b2ff:
            ii(0x1014_b2ff, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_b301, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1014_b306, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1014_b309, 7); cmp(memb[ds, eax + 0xab], 0);           /* cmp byte [eax+0xab], 0x0 */
            ii(0x1014_b310, 2); if(jz(0x1014_b316, 4)) goto l_0x1014_b316; /* jz 0x1014b316 */
            ii(0x1014_b312, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
        l_0x1014_b316:
            ii(0x1014_b316, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1014_b31a, 2); if(jnz(0x1014_b325, 9)) goto l_0x1014_b325; /* jnz 0x1014b325 */
            ii(0x1014_b31c, 7); cmp(memb[ds, 0x101c_3980], 0);          /* cmp byte [0x101c3980], 0x0 */
            ii(0x1014_b323, 2); if(jz(0x1014_b32d, 8)) goto l_0x1014_b32d; /* jz 0x1014b32d */
        l_0x1014_b325:
            ii(0x1014_b325, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b328, 5); call(0x1014_9fa8, -0x1385);             /* call 0x10149fa8 */
        l_0x1014_b32d:
            ii(0x1014_b32d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b330, 5); cmp(memw[ds, eax + 8], 0x42);           /* cmp word [eax+0x8], 0x42 */
            ii(0x1014_b335, 2); if(jz(0x1014_b341, 0xa)) goto l_0x1014_b341; /* jz 0x1014b341 */
            ii(0x1014_b337, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b33a, 5); cmp(memw[ds, eax + 8], 0x43);           /* cmp word [eax+0x8], 0x43 */
            ii(0x1014_b33f, 2); if(jnz(0x1014_b395, 0x54)) goto l_0x1014_b395; /* jnz 0x1014b395 */
        l_0x1014_b341:
            ii(0x1014_b341, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b344, 6); mov(edx, memd[ds, eax + 0xd3]);         /* mov edx, [eax+0xd3] */
            ii(0x1014_b34a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_b34d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b350, 3); mov(eax, memd[ds, eax + 0x39]);         /* mov eax, [eax+0x39] */
            ii(0x1014_b353, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_b356, 3); add(edx, 8);                            /* add edx, 0x8 */
            ii(0x1014_b359, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_b35b, 2); if(jle(0x1014_b37b, 0x1e)) goto l_0x1014_b37b; /* jle 0x1014b37b */
            ii(0x1014_b35d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b360, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b362, 3); mov(dl, memb[ds, eax + 0x29]);          /* mov dl, [eax+0x29] */
            ii(0x1014_b365, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b368, 4); mov(ax, memw[ds, eax + 0x33]);          /* mov ax, [eax+0x33] */
            ii(0x1014_b36c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_b36e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_b371, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b374, 5); call(0x1014_9b07, -0x1872);             /* call 0x10149b07 */
            ii(0x1014_b379, 2); jmp(0x1014_b395, 0x1a); goto l_0x1014_b395; /* jmp 0x1014b395 */
        l_0x1014_b37b:
            ii(0x1014_b37b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b37e, 7); mov(ax, memw[ds, eax + 0xd5]);          /* mov ax, [eax+0xd5] */
            ii(0x1014_b385, 5); add(eax, 8);                            /* add eax, 0x8 */
            ii(0x1014_b38a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_b38d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b390, 5); call(0x1014_9b07, -0x188e);             /* call 0x10149b07 */
        l_0x1014_b395:
            ii(0x1014_b395, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b398, 3); mov(al, memb[ds, eax + 0x5e]);          /* mov al, [eax+0x5e] */
            ii(0x1014_b39b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_b3a0, 3); cmp(eax, 0x40);                         /* cmp eax, 0x40 */
            ii(0x1014_b3a3, 6); if(jnz(0x1014_b598, 0x1ef)) goto l_0x1014_b598; /* jnz 0x1014b598 */
            ii(0x1014_b3a9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b3ac, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1014_b3af, 5); call(0x1007_69d8, -0xd_49dc);           /* call 0x100769d8 */
            ii(0x1014_b3b4, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x1014_b3b7, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x1014_b3ba, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1014_b3bd, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_b3c0, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x1014_b3c3, 3); call_abs(memd[ds, ebx + 0x2c]);         /* call dword [ebx+0x2c] */
            ii(0x1014_b3c6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b3c9, 4); cmp(memb[ds, eax + 0x3d], 4);           /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1014_b3cd, 2); if(jnz(0x1014_b3df, 0x10)) goto l_0x1014_b3df; /* jnz 0x1014b3df */
            ii(0x1014_b3cf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b3d2, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1014_b3d5, 5); call(Definitions.my_2_get_count, -0xc_0072); /* call 0x1008b368 */
            ii(0x1014_b3da, 1); cwde();                                 /* cwde */
            ii(0x1014_b3db, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_b3dd, 2); if(jg(0x1014_b3e1, 2)) goto l_0x1014_b3e1; /* jg 0x1014b3e1 */
        l_0x1014_b3df:
            ii(0x1014_b3df, 2); jmp(0x1014_b420, 0x3f); goto l_0x1014_b420; /* jmp 0x1014b420 */
        l_0x1014_b3e1:
            ii(0x1014_b3e1, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1014_b3e6, 1); push(eax);                              /* push eax */
            ii(0x1014_b3e7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b3ea, 3); mov(ecx, memd[ds, eax + 0x1a]);         /* mov ecx, [eax+0x1a] */
            ii(0x1014_b3ed, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1014_b3f0, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1014_b3f3, 3); mov(ebx, memd[ds, ebx + 0x18]);         /* mov ebx, [ebx+0x18] */
            ii(0x1014_b3f6, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_b3f9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b3fc, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1014_b3ff, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_b401, 3); movsx(esi, ax);                         /* movsx esi, ax */
            ii(0x1014_b404, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b406, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b409, 3); add(eax, 0x74);                         /* add eax, 0x74 */
            ii(0x1014_b40c, 5); call(0x1008_b228, -0xc_01e9);           /* call 0x1008b228 */
            ii(0x1014_b411, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1014_b414, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1014_b416, 5); call(0x1007_02b9, -0xd_b162);           /* call 0x100702b9 */
            ii(0x1014_b41b, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1014_b41e, 2); if(jnz(0x1014_b422, 2)) goto l_0x1014_b422; /* jnz 0x1014b422 */
        l_0x1014_b420:
            ii(0x1014_b420, 2); jmp(0x1014_b42c, 0xa); goto l_0x1014_b42c; /* jmp 0x1014b42c */
        l_0x1014_b422:
            ii(0x1014_b422, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b425, 5); call(0x1014_ae37, -0x5f3);              /* call 0x1014ae37 */
            ii(0x1014_b42a, 2); jmp(0x1014_b433, 7); goto l_0x1014_b433; /* jmp 0x1014b433 */
        l_0x1014_b42c:
            ii(0x1014_b42c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b42f, 4); mov(memb[ds, eax + 0x3e], 5);           /* mov byte [eax+0x3e], 0x5 */
        l_0x1014_b433:
            ii(0x1014_b433, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b436, 4); cmp(memb[ds, eax + 0x3d], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1014_b43a, 2); if(jz(0x1014_b445, 9)) goto l_0x1014_b445; /* jz 0x1014b445 */
            ii(0x1014_b43c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b43f, 4); cmp(memb[ds, eax + 0x3d], 0x1b);        /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1014_b443, 2); if(jnz(0x1014_b447, 2)) goto l_0x1014_b447; /* jnz 0x1014b447 */
        l_0x1014_b445:
            ii(0x1014_b445, 2); jmp(0x1014_b450, 9); goto l_0x1014_b450; /* jmp 0x1014b450 */
        l_0x1014_b447:
            ii(0x1014_b447, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b44a, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1014_b44e, 2); if(jnz(0x1014_b458, 8)) goto l_0x1014_b458; /* jnz 0x1014b458 */
        l_0x1014_b450:
            ii(0x1014_b450, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b453, 5); call(0x1014_f12b, 0x3cd3);              /* call 0x1014f12b */
        l_0x1014_b458:
            ii(0x1014_b458, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1014_b45d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b460, 5); call(0x1007_6d98, -0xd_46cd);           /* call 0x10076d98 */
            ii(0x1014_b465, 2); test(al, al);                           /* test al, al */
            ii(0x1014_b467, 2); if(jz(0x1014_b476, 0xd)) goto l_0x1014_b476; /* jz 0x1014b476 */
            ii(0x1014_b469, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_b46c, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1014_b471, 5); call(0x1013_de44, -0xd632);             /* call 0x1013de44 */
        l_0x1014_b476:
            ii(0x1014_b476, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b479, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1014_b47c, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_b47e, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1014_b481, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b484, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1014_b487, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_b48a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b48d, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1014_b490, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_b493, 3); lea(eax, memd[ss, ebp - 0x58]);         /* lea eax, [ebp-0x58] */
            ii(0x1014_b496, 5); call(0x1007_6aac, -0xd_49ef);           /* call 0x10076aac */
            ii(0x1014_b49b, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1014_b49d, 5); call(0x100a_9239, -0xa_2269);           /* call 0x100a9239 */
            ii(0x1014_b4a2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b4a5, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1014_b4a8, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_b4ab, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b4ae, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1014_b4b1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_b4b4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b4b7, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1014_b4ba, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_b4bc, 1); cwde();                                 /* cwde */
            ii(0x1014_b4bd, 5); call(0x1007_4e0c, -0xd_66b6);           /* call 0x10074e0c */
            ii(0x1014_b4c2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_b4c4, 3); lea(eax, memd[ss, ebp - 0x5c]);         /* lea eax, [ebp-0x5c] */
            ii(0x1014_b4c7, 5); call(0x1007_66ac, -0xd_4e20);           /* call 0x100766ac */
            ii(0x1014_b4cc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b4ce, 3); lea(eax, memd[ss, ebp - 0x5c]);         /* lea eax, [ebp-0x5c] */
            ii(0x1014_b4d1, 5); call(0x1013_ad71, -0x1_0765);           /* call 0x1013ad71 */
            ii(0x1014_b4d6, 2); test(al, al);                           /* test al, al */
            ii(0x1014_b4d8, 6); if(jz(0x1014_b566, 0x88)) goto l_0x1014_b566; /* jz 0x1014b566 */
            ii(0x1014_b4de, 3); lea(eax, memd[ss, ebp - 0x5c]);         /* lea eax, [ebp-0x5c] */
            ii(0x1014_b4e1, 5); call(0x1007_6574, -0xd_4f72);           /* call 0x10076574 */
            ii(0x1014_b4e6, 4); mov(memb[ds, eax + 0x3d], 9);           /* mov byte [eax+0x3d], 0x9 */
            ii(0x1014_b4ea, 3); lea(eax, memd[ss, ebp - 0x5c]);         /* lea eax, [ebp-0x5c] */
            ii(0x1014_b4ed, 5); call(0x1007_6574, -0xd_4f7e);           /* call 0x10076574 */
            ii(0x1014_b4f2, 4); mov(memb[ds, eax + 0x3e], 0x1b);        /* mov byte [eax+0x3e], 0x1b */
            ii(0x1014_b4f6, 3); lea(eax, memd[ss, ebp - 0x5c]);         /* lea eax, [ebp-0x5c] */
            ii(0x1014_b4f9, 5); call(0x1007_6574, -0xd_4f8a);           /* call 0x10076574 */
            ii(0x1014_b4fe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_b500, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b503, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1014_b506, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_b50b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_b50d, 7); mov(memb[ds, eax + 0xab], 1);           /* mov byte [eax+0xab], 0x1 */
            ii(0x1014_b514, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b517, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1014_b51a, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1014_b51c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_b51f, 3); lea(eax, memd[ss, ebp - 0x5c]);         /* lea eax, [ebp-0x5c] */
            ii(0x1014_b522, 5); call(0x1007_65d0, -0xd_4f57);           /* call 0x100765d0 */
            ii(0x1014_b527, 5); call(0x100a_9060, -0xa_24cc);           /* call 0x100a9060 */
            ii(0x1014_b52c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b52f, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1014_b533, 2); if(jnz(0x1014_b53c, 7)) goto l_0x1014_b53c; /* jnz 0x1014b53c */
            ii(0x1014_b535, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b538, 4); mov(memb[ds, eax + 0x3d], 0);           /* mov byte [eax+0x3d], 0x0 */
        l_0x1014_b53c:
            ii(0x1014_b53c, 5); call(0x1012_0a90, -0x2_aab1);           /* call 0x10120a90 */
            ii(0x1014_b541, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b543, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1014_b545, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b548, 5); call(0x1014_f017, 0x3aca);              /* call 0x1014f017 */
            ii(0x1014_b54d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b54f, 3); lea(eax, memd[ss, ebp - 0x5c]);         /* lea eax, [ebp-0x5c] */
            ii(0x1014_b552, 5); call(0x1007_5f2c, -0xd_562b);           /* call 0x10075f2c */
            ii(0x1014_b557, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b559, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1014_b55c, 5); call(0x1007_5f2c, -0xd_5635);           /* call 0x10075f2c */
            ii(0x1014_b561, 5); jmp(0x1014_b5e6, 0x80); goto l_0x1014_b5e6; /* jmp 0x1014b5e6 */
        l_0x1014_b566:
            ii(0x1014_b566, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b569, 7); cmp(memb[ds, eax + 0xa6], 2);           /* cmp byte [eax+0xa6], 0x2 */
            ii(0x1014_b570, 2); if(jnz(0x1014_b57a, 8)) goto l_0x1014_b57a; /* jnz 0x1014b57a */
            ii(0x1014_b572, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b575, 5); call(0x1015_3997, 0x841d);              /* call 0x10153997 */
        l_0x1014_b57a:
            ii(0x1014_b57a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b57d, 7); cmp(memb[ds, eax + 0xa6], 1);           /* cmp byte [eax+0xa6], 0x1 */
            ii(0x1014_b584, 2); if(jnz(0x1014_b58e, 8)) goto l_0x1014_b58e; /* jnz 0x1014b58e */
            ii(0x1014_b586, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b589, 5); call(0x1015_3c48, 0x86ba);              /* call 0x10153c48 */
        l_0x1014_b58e:
            ii(0x1014_b58e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b590, 3); lea(eax, memd[ss, ebp - 0x5c]);         /* lea eax, [ebp-0x5c] */
            ii(0x1014_b593, 5); call(0x1007_5f2c, -0xd_566c);           /* call 0x10075f2c */
        l_0x1014_b598:
            ii(0x1014_b598, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1014_b59f, 2); if(jz(0x1014_b5ad, 0xc)) goto l_0x1014_b5ad; /* jz 0x1014b5ad */
            ii(0x1014_b5a1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b5a3, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1014_b5a6, 5); call(0x1007_5f2c, -0xd_567f);           /* call 0x10075f2c */
            ii(0x1014_b5ab, 2); jmp(0x1014_b5e6, 0x39); goto l_0x1014_b5e6; /* jmp 0x1014b5e6 */
        l_0x1014_b5ad:
            ii(0x1014_b5ad, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b5b0, 4); cmp(memb[ds, eax + 0x3e], 5);           /* cmp byte [eax+0x3e], 0x5 */
            ii(0x1014_b5b4, 2); if(jnz(0x1014_b5bc, 6)) goto l_0x1014_b5bc; /* jnz 0x1014b5bc */
            ii(0x1014_b5b6, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1014_b5ba, 2); if(jz(0x1014_b5be, 2)) goto l_0x1014_b5be; /* jz 0x1014b5be */
        l_0x1014_b5bc:
            ii(0x1014_b5bc, 2); jmp(0x1014_b5c6, 8); goto l_0x1014_b5c6; /* jmp 0x1014b5c6 */
        l_0x1014_b5be:
            ii(0x1014_b5be, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b5c1, 5); call(0x1014_ac97, -0x92f);              /* call 0x1014ac97 */
        l_0x1014_b5c6:
            ii(0x1014_b5c6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_b5c9, 4); cmp(memb[ds, eax + 0x3e], 6);           /* cmp byte [eax+0x3e], 0x6 */
            ii(0x1014_b5cd, 2); if(jnz(0x1014_b5d5, 6)) goto l_0x1014_b5d5; /* jnz 0x1014b5d5 */
            ii(0x1014_b5cf, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1014_b5d3, 2); if(jz(0x1014_b5d7, 2)) goto l_0x1014_b5d7; /* jz 0x1014b5d7 */
        l_0x1014_b5d5:
            ii(0x1014_b5d5, 2); jmp(0x1014_b5dc, 5); goto l_0x1014_b5dc; /* jmp 0x1014b5dc */
        l_0x1014_b5d7:
            ii(0x1014_b5d7, 5); jmp(0x1014_af70, -0x66c); goto l_0x1014_af70; /* jmp 0x1014af70 */
        l_0x1014_b5dc:
            ii(0x1014_b5dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_b5de, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1014_b5e1, 5); call(0x1007_5f2c, -0xd_56ba);           /* call 0x10075f2c */
        l_0x1014_b5e6:
            ii(0x1014_b5e6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_b5e8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_b5e9, 1); pop(edi);                               /* pop edi */
            ii(0x1014_b5ea, 1); pop(esi);                               /* pop esi */
            ii(0x1014_b5eb, 1); pop(edx);                               /* pop edx */
            ii(0x1014_b5ec, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_b5ed, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_b5ee, 1); ret();                                  /* ret */
        }
    }
}
