using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_dee1-25e0bbb9")]
        public void /* sys */ Method_1018_dee1()
        {
            ii(0x1018_dee1, 1); push(ebp);                              /* push ebp */
            ii(0x1018_dee2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_dee4, 3); add(esp, -0x10 /* 0xf0 */);             /* add esp, 0xfffffff0 */
            ii(0x1018_dee7, 1); push(esi);                              /* push esi */
            ii(0x1018_dee8, 1); push(edi);                              /* push edi */
            ii(0x1018_dee9, 1); push(ebx);                              /* push ebx */
            ii(0x1018_deea, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1018_deed, 3); mov(es, ax);                            /* mov es, ax */
            ii(0x1018_def0, 5); mov(eax, memd[ds, 0x1020_9cd8]);        /* mov eax, [0x10209cd8] */
            ii(0x1018_def5, 6); sub(eax, memd[ds, 0x1020_9cc8]);        /* sub eax, [0x10209cc8] */
            ii(0x1018_defb, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1018_defe, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_df00, 6); mov(bl, memb[ds, 0x1020_9dd2]);         /* mov bl, [0x10209dd2] */
            ii(0x1018_df06, 3); mov(eax, memd[ss, ebp + 0xc]);          /* mov eax, [ebp+0xc] */
            ii(0x1018_df09, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1018_df0c, 5); mov(memd[ds, 0x1020_9ce0], eax);        /* mov [0x10209ce0], eax */
            ii(0x1018_df11, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1018_df14, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1018_df17, 5); mov(memd[ds, 0x1020_9cdc], eax);        /* mov [0x10209cdc], eax */
            ii(0x1018_df1c, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1018_df1f, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1018_df22, 2); mul(ebx);                               /* mul ebx */
            ii(0x1018_df24, 5); mov(memd[ds, 0x1020_9ce4], eax);        /* mov [0x10209ce4], eax */
            ii(0x1018_df29, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1018_df2c, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1018_df2f, 2); mul(ebx);                               /* mul ebx */
            ii(0x1018_df31, 5); mov(memd[ds, 0x1020_9cd4], eax);        /* mov [0x10209cd4], eax */
            ii(0x1018_df36, 5); mov(eax, memd[ds, 0x1020_9cc4]);        /* mov eax, [0x10209cc4] */
            ii(0x1018_df3b, 6); sub(eax, memd[ds, 0x1020_9cdc]);        /* sub eax, [0x10209cdc] */
            ii(0x1018_df41, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1018_df44, 5); mov(eax, memd[ds, 0x1020_9cc8]);        /* mov eax, [0x10209cc8] */
            ii(0x1018_df49, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1018_df4c, 4); cmp(memd[ss, ebp + 0xc], 0);            /* cmp dword [ebp+0xc], 0x0 */
            ii(0x1018_df50, 2); if(jnz(0x1018_df58, 0x6)) goto l_0x1018_df58; /* jnz 0x1018df58 */
            ii(0x1018_df52, 4); cmp(memd[ss, ebp + 0x10], 0);           /* cmp dword [ebp+0x10], 0x0 */
            ii(0x1018_df56, 2); if(jz(0x1018_df6c, 0x14)) goto l_0x1018_df6c; /* jz 0x1018df6c */
        l_0x1018_df58:
            ii(0x1018_df58, 5); mov(eax, memd[ds, 0x1020_9ce4]);        /* mov eax, [0x10209ce4] */
            ii(0x1018_df5d, 6); mul(memd[ds, 0x1020_9cd0]);             /* mul dword [0x10209cd0] */
            ii(0x1018_df63, 6); add(eax, memd[ds, 0x1020_9ce0]);        /* add eax, [0x10209ce0] */
            ii(0x1018_df69, 3); add(memd[ss, ebp - 0x4], eax);          /* add [ebp-0x4], eax */
        l_0x1018_df6c:
            ii(0x1018_df6c, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1018_df6f, 3); mul(memd[ss, ebp + 0x18]);              /* mul dword [ebp+0x18] */
            ii(0x1018_df72, 2); mul(ebx);                               /* mul ebx */
            ii(0x1018_df74, 2); shl(eax, 0x1);                          /* shl eax, 1 */
            ii(0x1018_df76, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1018_df79, 3); mov(edi, memd[ss, ebp - 0x4]);          /* mov edi, [ebp-0x4] */
            ii(0x1018_df7c, 6); mov(edx, memd[ds, 0x1020_9ce8]);        /* mov edx, [0x10209ce8] */
            ii(0x1018_df82, 3); mov(ebx, memd[ss, ebp + 0x8]);          /* mov ebx, [ebp+0x8] */
            ii(0x1018_df85, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1018_df87, 3); add(esi, memd[ss, ebp - 0x10]);         /* add esi, [ebp-0x10] */
            ii(0x1018_df8a, 6); mov(cl, memb[ds, 0x1020_9dd2]);         /* mov cl, [0x10209dd2] */
        l_0x1018_df90:
            ii(0x1018_df90, 1); push(ecx);                              /* push ecx */
            ii(0x1018_df91, 1); push(edi);                              /* push edi */
            ii(0x1018_df92, 3); mov(ch, memb[ss, ebp + 0x18]);          /* mov ch, [ebp+0x18] */
        l_0x1018_df95:
            ii(0x1018_df95, 3); mov(cl, memb[ss, ebp + 0x14]);          /* mov cl, [ebp+0x14] */
        l_0x1018_df98:
            ii(0x1018_df98, 4); cmp(memw[ds, ebx], 0);                  /* cmp word [ebx], 0x0 */
            ii(0x1018_df9c, 2); if(jz(0x1018_dfbd, 0x1f)) goto l_0x1018_dfbd; /* jz 0x1018dfbd */
            ii(0x1018_df9e, 3); add(edi, 0x10);                         /* add edi, 0x10 */
        l_0x1018_dfa1:
            ii(0x1018_dfa1, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
            ii(0x1018_dfa4, 2); dec(cl);                                /* dec cl */
            ii(0x1018_dfa6, 2); if(jnz(0x1018_df98, -0x10)) goto l_0x1018_df98; /* jnz 0x1018df98 */
            ii(0x1018_dfa8, 3); add(edi, memd[ss, ebp - 0x8]);          /* add edi, [ebp-0x8] */
            ii(0x1018_dfab, 2); dec(ch);                                /* dec ch */
            ii(0x1018_dfad, 2); if(jnz(0x1018_df95, -0x1a)) goto l_0x1018_df95; /* jnz 0x1018df95 */
            ii(0x1018_dfaf, 1); pop(edi);                               /* pop edi */
            ii(0x1018_dfb0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_dfb1, 6); add(edi, memd[ds, 0x1020_9cd0]);        /* add edi, [0x10209cd0] */
            ii(0x1018_dfb7, 2); dec(cl);                                /* dec cl */
            ii(0x1018_dfb9, 2); if(jnz(0x1018_df90, -0x2b)) goto l_0x1018_df90; /* jnz 0x1018df90 */
            ii(0x1018_dfbb, 2); jmp(0x1018_dff3, 0x36); goto l_0x1018_dff3; /* jmp 0x1018dff3 */
        l_0x1018_dfbd:
            ii(0x1018_dfbd, 1); movsd();                                /* movsd */
            ii(0x1018_dfbe, 1); movsd();                                /* movsd */
            ii(0x1018_dfbf, 1); movsd();                                /* movsd */
            ii(0x1018_dfc0, 1); movsd();                                /* movsd */
            ii(0x1018_dfc1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_dfc3, 1); movsd();                                /* movsd */
            ii(0x1018_dfc4, 1); movsd();                                /* movsd */
            ii(0x1018_dfc5, 1); movsd();                                /* movsd */
            ii(0x1018_dfc6, 1); movsd();                                /* movsd */
            ii(0x1018_dfc7, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_dfc9, 1); movsd();                                /* movsd */
            ii(0x1018_dfca, 1); movsd();                                /* movsd */
            ii(0x1018_dfcb, 1); movsd();                                /* movsd */
            ii(0x1018_dfcc, 1); movsd();                                /* movsd */
            ii(0x1018_dfcd, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_dfcf, 1); movsd();                                /* movsd */
            ii(0x1018_dfd0, 1); movsd();                                /* movsd */
            ii(0x1018_dfd1, 1); movsd();                                /* movsd */
            ii(0x1018_dfd2, 1); movsd();                                /* movsd */
            ii(0x1018_dfd3, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_dfd5, 1); movsd();                                /* movsd */
            ii(0x1018_dfd6, 1); movsd();                                /* movsd */
            ii(0x1018_dfd7, 1); movsd();                                /* movsd */
            ii(0x1018_dfd8, 1); movsd();                                /* movsd */
            ii(0x1018_dfd9, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_dfdb, 1); movsd();                                /* movsd */
            ii(0x1018_dfdc, 1); movsd();                                /* movsd */
            ii(0x1018_dfdd, 1); movsd();                                /* movsd */
            ii(0x1018_dfde, 1); movsd();                                /* movsd */
            ii(0x1018_dfdf, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_dfe1, 1); movsd();                                /* movsd */
            ii(0x1018_dfe2, 1); movsd();                                /* movsd */
            ii(0x1018_dfe3, 1); movsd();                                /* movsd */
            ii(0x1018_dfe4, 1); movsd();                                /* movsd */
            ii(0x1018_dfe5, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_dfe7, 1); movsd();                                /* movsd */
            ii(0x1018_dfe8, 1); movsd();                                /* movsd */
            ii(0x1018_dfe9, 1); movsd();                                /* movsd */
            ii(0x1018_dfea, 1); movsd();                                /* movsd */
            ii(0x1018_dfeb, 6); sub(edi, memd[ds, 0x1020_9cec]);        /* sub edi, [0x10209cec] */
            ii(0x1018_dff1, 2); jmp(0x1018_dfa1, -0x52); goto l_0x1018_dfa1; /* jmp 0x1018dfa1 */
        l_0x1018_dff3:
            ii(0x1018_dff3, 3); sub(ebx, memd[ss, ebp - 0x10]);         /* sub ebx, [ebp-0x10] */
            ii(0x1018_dff6, 3); mov(edi, memd[ss, ebp - 0x4]);          /* mov edi, [ebp-0x4] */
            ii(0x1018_dff9, 6); mov(cl, memb[ds, 0x1020_9dd2]);         /* mov cl, [0x10209dd2] */
            ii(0x1018_dfff, 2); xor(esi, esi);                          /* xor esi, esi */
        l_0x1018_e001:
            ii(0x1018_e001, 1); push(ecx);                              /* push ecx */
            ii(0x1018_e002, 1); push(edi);                              /* push edi */
            ii(0x1018_e003, 3); mov(ch, memb[ss, ebp + 0x18]);          /* mov ch, [ebp+0x18] */
        l_0x1018_e006:
            ii(0x1018_e006, 3); mov(cl, memb[ss, ebp + 0x14]);          /* mov cl, [ebp+0x14] */
        l_0x1018_e009:
            ii(0x1018_e009, 3); or(si, memw[ds, ebx]);                  /* or si, [ebx] */
            ii(0x1018_e00c, 2); if(jg(0x1018_e034, 0x26)) goto l_0x1018_e034; /* jg 0x1018e034 */
            ii(0x1018_e00e, 2); if(jl(0x1018_e032, 0x22)) goto l_0x1018_e032; /* jl 0x1018e032 */
            ii(0x1018_e010, 3); add(edi, 0x10);                         /* add edi, 0x10 */
        l_0x1018_e013:
            ii(0x1018_e013, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
            ii(0x1018_e016, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e018, 2); if(jnz(0x1018_e009, -0x11)) goto l_0x1018_e009; /* jnz 0x1018e009 */
            ii(0x1018_e01a, 3); add(edi, memd[ss, ebp - 0x8]);          /* add edi, [ebp-0x8] */
            ii(0x1018_e01d, 2); dec(ch);                                /* dec ch */
            ii(0x1018_e01f, 2); if(jnz(0x1018_e006, -0x1b)) goto l_0x1018_e006; /* jnz 0x1018e006 */
            ii(0x1018_e021, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e022, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_e023, 6); add(edi, memd[ds, 0x1020_9cd0]);        /* add edi, [0x10209cd0] */
            ii(0x1018_e029, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e02b, 2); if(jnz(0x1018_e001, -0x2c)) goto l_0x1018_e001; /* jnz 0x1018e001 */
            ii(0x1018_e02d, 5); jmp(0x1018_e101, 0xcf); goto l_0x1018_e101; /* jmp 0x1018e101 */
        l_0x1018_e032:
            ii(0x1018_e032, 2); jmp(0x1018_e0b1, 0x7d); goto l_0x1018_e0b1; /* jmp 0x1018e0b1 */
        l_0x1018_e034:
            ii(0x1018_e034, 7); lea(esi, memd[ds, edi + esi * 2 - 0x8000]); /* lea esi, [edi+esi*2-0x8000] */
            ii(0x1018_e03b, 1); movsd();                                /* movsd */
            ii(0x1018_e03c, 1); movsd();                                /* movsd */
            ii(0x1018_e03d, 1); movsd();                                /* movsd */
            ii(0x1018_e03e, 1); movsd();                                /* movsd */
            ii(0x1018_e03f, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e041, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e043, 1); movsd();                                /* movsd */
            ii(0x1018_e044, 1); movsd();                                /* movsd */
            ii(0x1018_e045, 1); movsd();                                /* movsd */
            ii(0x1018_e046, 1); movsd();                                /* movsd */
            ii(0x1018_e047, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e049, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e04b, 1); movsd();                                /* movsd */
            ii(0x1018_e04c, 1); movsd();                                /* movsd */
            ii(0x1018_e04d, 1); movsd();                                /* movsd */
            ii(0x1018_e04e, 1); movsd();                                /* movsd */
            ii(0x1018_e04f, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e051, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e053, 1); movsd();                                /* movsd */
            ii(0x1018_e054, 1); movsd();                                /* movsd */
            ii(0x1018_e055, 1); movsd();                                /* movsd */
            ii(0x1018_e056, 1); movsd();                                /* movsd */
            ii(0x1018_e057, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e059, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e05b, 1); movsd();                                /* movsd */
            ii(0x1018_e05c, 1); movsd();                                /* movsd */
            ii(0x1018_e05d, 1); movsd();                                /* movsd */
            ii(0x1018_e05e, 1); movsd();                                /* movsd */
            ii(0x1018_e05f, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e061, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e063, 1); movsd();                                /* movsd */
            ii(0x1018_e064, 1); movsd();                                /* movsd */
            ii(0x1018_e065, 1); movsd();                                /* movsd */
            ii(0x1018_e066, 1); movsd();                                /* movsd */
            ii(0x1018_e067, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e069, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e06b, 1); movsd();                                /* movsd */
            ii(0x1018_e06c, 1); movsd();                                /* movsd */
            ii(0x1018_e06d, 1); movsd();                                /* movsd */
            ii(0x1018_e06e, 1); movsd();                                /* movsd */
            ii(0x1018_e06f, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e071, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e073, 1); movsd();                                /* movsd */
            ii(0x1018_e074, 1); movsd();                                /* movsd */
            ii(0x1018_e075, 1); movsd();                                /* movsd */
            ii(0x1018_e076, 1); movsd();                                /* movsd */
            ii(0x1018_e077, 6); sub(edi, memd[ds, 0x1020_9cec]);        /* sub edi, [0x10209cec] */
            ii(0x1018_e07d, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1018_e07f, 2); jmp(0x1018_e013, -0x6e); goto l_0x1018_e013; /* jmp 0x1018e013 */
        l_0x1018_e081:
            ii(0x1018_e081, 1); push(ecx);                              /* push ecx */
            ii(0x1018_e082, 1); push(edi);                              /* push edi */
            ii(0x1018_e083, 3); mov(ch, memb[ss, ebp + 0x18]);          /* mov ch, [ebp+0x18] */
        l_0x1018_e086:
            ii(0x1018_e086, 3); mov(cl, memb[ss, ebp + 0x14]);          /* mov cl, [ebp+0x14] */
        l_0x1018_e089:
            ii(0x1018_e089, 3); or(si, memw[ds, ebx]);                  /* or si, [ebx] */
            ii(0x1018_e08c, 2); if(jl(0x1018_e0b1, 0x23)) goto l_0x1018_e0b1; /* jl 0x1018e0b1 */
            ii(0x1018_e08e, 2); if(jg(0x1018_e0af, 0x1f)) goto l_0x1018_e0af; /* jg 0x1018e0af */
            ii(0x1018_e090, 3); add(edi, 0x10);                         /* add edi, 0x10 */
        l_0x1018_e093:
            ii(0x1018_e093, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
            ii(0x1018_e096, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e098, 2); if(jnz(0x1018_e089, -0x11)) goto l_0x1018_e089; /* jnz 0x1018e089 */
            ii(0x1018_e09a, 3); add(edi, memd[ss, ebp - 0x8]);          /* add edi, [ebp-0x8] */
            ii(0x1018_e09d, 2); dec(ch);                                /* dec ch */
            ii(0x1018_e09f, 2); if(jnz(0x1018_e086, -0x1b)) goto l_0x1018_e086; /* jnz 0x1018e086 */
            ii(0x1018_e0a1, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e0a2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_e0a3, 6); add(edi, memd[ds, 0x1020_9cd0]);        /* add edi, [0x10209cd0] */
            ii(0x1018_e0a9, 2); dec(cl);                                /* dec cl */
            ii(0x1018_e0ab, 2); if(jnz(0x1018_e081, -0x2c)) goto l_0x1018_e081; /* jnz 0x1018e081 */
            ii(0x1018_e0ad, 2); jmp(0x1018_e101, 0x52); goto l_0x1018_e101; /* jmp 0x1018e101 */
        l_0x1018_e0af:
            ii(0x1018_e0af, 2); jmp(0x1018_e034, -0x7d); goto l_0x1018_e034; /* jmp 0x1018e034 */
        l_0x1018_e0b1:
            ii(0x1018_e0b1, 7); lea(esi, memd[ds, edi + esi * 2 - 0x18000]); /* lea esi, [edi+esi*2-0x18000] */
            ii(0x1018_e0b8, 3); add(esi, memd[ss, ebp - 0xc]);          /* add esi, [ebp-0xc] */
            ii(0x1018_e0bb, 1); movsd();                                /* movsd */
            ii(0x1018_e0bc, 1); movsd();                                /* movsd */
            ii(0x1018_e0bd, 1); movsd();                                /* movsd */
            ii(0x1018_e0be, 1); movsd();                                /* movsd */
            ii(0x1018_e0bf, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e0c1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e0c3, 1); movsd();                                /* movsd */
            ii(0x1018_e0c4, 1); movsd();                                /* movsd */
            ii(0x1018_e0c5, 1); movsd();                                /* movsd */
            ii(0x1018_e0c6, 1); movsd();                                /* movsd */
            ii(0x1018_e0c7, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e0c9, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e0cb, 1); movsd();                                /* movsd */
            ii(0x1018_e0cc, 1); movsd();                                /* movsd */
            ii(0x1018_e0cd, 1); movsd();                                /* movsd */
            ii(0x1018_e0ce, 1); movsd();                                /* movsd */
            ii(0x1018_e0cf, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e0d1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e0d3, 1); movsd();                                /* movsd */
            ii(0x1018_e0d4, 1); movsd();                                /* movsd */
            ii(0x1018_e0d5, 1); movsd();                                /* movsd */
            ii(0x1018_e0d6, 1); movsd();                                /* movsd */
            ii(0x1018_e0d7, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e0d9, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e0db, 1); movsd();                                /* movsd */
            ii(0x1018_e0dc, 1); movsd();                                /* movsd */
            ii(0x1018_e0dd, 1); movsd();                                /* movsd */
            ii(0x1018_e0de, 1); movsd();                                /* movsd */
            ii(0x1018_e0df, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e0e1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e0e3, 1); movsd();                                /* movsd */
            ii(0x1018_e0e4, 1); movsd();                                /* movsd */
            ii(0x1018_e0e5, 1); movsd();                                /* movsd */
            ii(0x1018_e0e6, 1); movsd();                                /* movsd */
            ii(0x1018_e0e7, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e0e9, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e0eb, 1); movsd();                                /* movsd */
            ii(0x1018_e0ec, 1); movsd();                                /* movsd */
            ii(0x1018_e0ed, 1); movsd();                                /* movsd */
            ii(0x1018_e0ee, 1); movsd();                                /* movsd */
            ii(0x1018_e0ef, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e0f1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e0f3, 1); movsd();                                /* movsd */
            ii(0x1018_e0f4, 1); movsd();                                /* movsd */
            ii(0x1018_e0f5, 1); movsd();                                /* movsd */
            ii(0x1018_e0f6, 1); movsd();                                /* movsd */
            ii(0x1018_e0f7, 6); sub(edi, memd[ds, 0x1020_9cec]);        /* sub edi, [0x10209cec] */
            ii(0x1018_e0fd, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1018_e0ff, 2); jmp(0x1018_e093, -0x6e); goto l_0x1018_e093; /* jmp 0x1018e093 */
        l_0x1018_e101:
            ii(0x1018_e101, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_e102, 1); pop(edi);                               /* pop edi */
            ii(0x1018_e103, 1); pop(esi);                               /* pop esi */
            ii(0x1018_e104, 1); leave();                                /* leave */
            ii(0x1018_e105, 1); ret();                                  /* ret */
        }
    }
}
