using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_ea6c-d7d1f341")]
        public void /* sys */ sys_fread_internal()
        {
            ii(0x1016_ea6c, 1); push(esi);                              /* push esi */
            ii(0x1016_ea6d, 1); push(edi);                              /* push edi */
            ii(0x1016_ea6e, 1); push(ebp);                              /* push ebp */
            ii(0x1016_ea6f, 3); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1016_ea72, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1016_ea74, 4); mov(memd[ss, esp + 4], edx);            /* mov [esp+0x4], edx */
            ii(0x1016_ea78, 3); mov(memd[ss, esp], ebx);                /* mov [esp], ebx */
            ii(0x1016_ea7b, 2); mov(ebp, ecx);                          /* mov ebp, ecx */
            ii(0x1016_ea7d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_ea7f, 4); mov(memd[ss, esp + 12], edx);           /* mov [esp+0xc], edx */
            ii(0x1016_ea83, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_ea85, 6); if(jz(0x1016_eb2c, 0xa1)) goto l_0x1016_eb2c; /* jz 0x1016eb2c */
            ii(0x1016_ea8b, 4); test(memb[ds, ecx + 4], 4);             /* test byte [ecx+0x4], 0x4 */
            ii(0x1016_ea8f, 6); if(jz(0x1016_eb54, 0xbf)) goto l_0x1016_eb54; /* jz 0x1016eb54 */
            ii(0x1016_ea95, 7); cmp(memd[ds, 0x101b_e1dc], 0);          /* cmp dword [0x101be1dc], 0x0 */
            ii(0x1016_ea9c, 6); if(jz(0x1016_eb37, 0x95)) goto l_0x1016_eb37; /* jz 0x1016eb37 */
            ii(0x1016_eaa2, 2); mov(esi, edi);                          /* mov esi, edi */
            ii(0x1016_eaa4, 4); mov(edi, memd[ss, esp + 4]);            /* mov edi, [esp+0x4] */
            ii(0x1016_eaa8, 3); imul(edi, ebx);                         /* imul edi, ebx */
            ii(0x1016_eaab, 5); mov(eax, memd[ds, 0x101b_e1d8]);        /* mov eax, [0x101be1d8] */
            ii(0x1016_eab0, 6); sub(eax, memd[ds, 0x101b_e1d4]);        /* sub eax, [0x101be1d4] */
            ii(0x1016_eab6, 2); cmp(edi, eax);                          /* cmp edi, eax */
            ii(0x1016_eab8, 2); if(jl(0x1016_eaef, 0x35)) goto l_0x1016_eaef; /* jl 0x1016eaef */
        l_0x1016_eaba:
            ii(0x1016_eaba, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1016_eabf, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_eac1, 3); mov(ecx, memd[ss, ebp + 12]);           /* mov ecx, [ebp+0xc] */
            ii(0x1016_eac4, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_eac6, 5); call(Definitions.sys_fread, 0x3aa1);    /* call 0x1017256c */
            ii(0x1016_eacb, 4); mov(ecx, memd[ss, esp + 12]);           /* mov ecx, [esp+0xc] */
            ii(0x1016_eacf, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1016_ead1, 2); sub(edi, eax);                          /* sub edi, eax */
            ii(0x1016_ead3, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1016_ead5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_ead7, 5); mov(memd[ds, 0x101b_e1d4], eax);        /* mov [0x101be1d4], eax */
            ii(0x1016_eadc, 6); call_abs(memd[ds, 0x101b_e1dc]);        /* call dword [0x101be1dc] */
            ii(0x1016_eae2, 5); mov(eax, memd[ds, 0x101b_e1d8]);        /* mov eax, [0x101be1d8] */
            ii(0x1016_eae7, 4); mov(memd[ss, esp + 12], ecx);           /* mov [esp+0xc], ecx */
            ii(0x1016_eaeb, 2); cmp(edi, eax);                          /* cmp edi, eax */
            ii(0x1016_eaed, 2); if(jge(0x1016_eaba, -0x35)) goto l_0x1016_eaba; /* jge 0x1016eaba */
        l_0x1016_eaef:
            ii(0x1016_eaef, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_eaf1, 2); if(jz(0x1016_eb1c, 0x29)) goto l_0x1016_eb1c; /* jz 0x1016eb1c */
            ii(0x1016_eaf3, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1016_eaf8, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_eafa, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_eafc, 3); mov(ecx, memd[ss, ebp + 12]);           /* mov ecx, [ebp+0xc] */
            ii(0x1016_eaff, 5); call(Definitions.sys_fread, 0x3a68);    /* call 0x1017256c */
            ii(0x1016_eb04, 4); mov(edx, memd[ss, esp + 12]);           /* mov edx, [esp+0xc] */
            ii(0x1016_eb08, 6); mov(ebx, memd[ds, 0x101b_e1d4]);        /* mov ebx, [0x101be1d4] */
            ii(0x1016_eb0e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_eb10, 2); add(ebx, edi);                          /* add ebx, edi */
            ii(0x1016_eb12, 4); mov(memd[ss, esp + 12], edx);           /* mov [esp+0xc], edx */
            ii(0x1016_eb16, 6); mov(memd[ds, 0x101b_e1d4], ebx);        /* mov [0x101be1d4], ebx */
        l_0x1016_eb1c:
            ii(0x1016_eb1c, 4); mov(eax, memd[ss, esp + 12]);           /* mov eax, [esp+0xc] */
            ii(0x1016_eb20, 4); mov(ecx, memd[ss, esp + 4]);            /* mov ecx, [esp+0x4] */
            ii(0x1016_eb24, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_eb26, 2); div(ecx);                               /* div ecx */
            ii(0x1016_eb28, 4); mov(memd[ss, esp + 12], eax);           /* mov [esp+0xc], eax */
        l_0x1016_eb2c:
            ii(0x1016_eb2c, 4); mov(eax, memd[ss, esp + 12]);           /* mov eax, [esp+0xc] */
            ii(0x1016_eb30, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1016_eb33, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_eb34, 1); pop(edi);                               /* pop edi */
            ii(0x1016_eb35, 1); pop(esi);                               /* pop esi */
            ii(0x1016_eb36, 1); ret(); return;                          /* ret */
        l_0x1016_eb37:
            ii(0x1016_eb37, 4); mov(edx, memd[ss, esp + 4]);            /* mov edx, [esp+0x4] */
            ii(0x1016_eb3b, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_eb3d, 3); mov(ecx, memd[ds, ecx + 12]);           /* mov ecx, [ecx+0xc] */
            ii(0x1016_eb40, 5); call(Definitions.sys_fread, 0x3a27);    /* call 0x1017256c */
            ii(0x1016_eb45, 4); mov(memd[ss, esp + 12], eax);           /* mov [esp+0xc], eax */
            ii(0x1016_eb49, 4); mov(eax, memd[ss, esp + 12]);           /* mov eax, [esp+0xc] */
            ii(0x1016_eb4d, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1016_eb50, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_eb51, 1); pop(edi);                               /* pop edi */
            ii(0x1016_eb52, 1); pop(esi);                               /* pop esi */
            ii(0x1016_eb53, 1); ret(); return;                          /* ret */
        l_0x1016_eb54:
            ii(0x1016_eb54, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_eb56, 2); if(jz(0x1016_eb2c, -0x2c)) goto l_0x1016_eb2c; /* jz 0x1016eb2c */
            ii(0x1016_eb58, 3); mov(eax, memd[ds, ecx + 4]);            /* mov eax, [ecx+0x4] */
            ii(0x1016_eb5b, 5); and(eax, 0xf0);                         /* and eax, 0xf0 */
            ii(0x1016_eb60, 3); cmp(eax, 0x20);                         /* cmp eax, 0x20 */
            ii(0x1016_eb63, 2); if(jb(0x1016_eb7f, 0x1a)) goto l_0x1016_eb7f; /* jb 0x1016eb7f */
            ii(0x1016_eb65, 6); if(jbe(0x1016_eca2, 0x137)) goto l_0x1016_eca2; /* jbe 0x1016eca2 */
            ii(0x1016_eb6b, 3); cmp(eax, 0x40);                         /* cmp eax, 0x40 */
            ii(0x1016_eb6e, 6); if(jz(0x1016_edf0, 0x27c)) goto l_0x1016_edf0; /* jz 0x1016edf0 */
            ii(0x1016_eb74, 4); mov(eax, memd[ss, esp + 12]);           /* mov eax, [esp+0xc] */
            ii(0x1016_eb78, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1016_eb7b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_eb7c, 1); pop(edi);                               /* pop edi */
            ii(0x1016_eb7d, 1); pop(esi);                               /* pop esi */
            ii(0x1016_eb7e, 1); ret(); return;                          /* ret */
        l_0x1016_eb7f:
            ii(0x1016_eb7f, 3); cmp(eax, 0x10);                         /* cmp eax, 0x10 */
            ii(0x1016_eb82, 2); if(jnz(0x1016_eb2c, -0x58)) goto l_0x1016_eb2c; /* jnz 0x1016eb2c */
            ii(0x1016_eb84, 3); mov(ebx, memd[ds, ecx + 16]);           /* mov ebx, [ecx+0x10] */
            ii(0x1016_eb87, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_eb89, 2); if(jbe(0x1016_eb2c, -0x5f)) goto l_0x1016_eb2c; /* jbe 0x1016eb2c */
            ii(0x1016_eb8b, 4); mov(ecx, memd[ss, esp + 4]);            /* mov ecx, [esp+0x4] */
            ii(0x1016_eb8f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_eb91, 2); div(ecx);                               /* div ecx */
            ii(0x1016_eb93, 3); mov(esi, memd[ss, esp]);                /* mov esi, [esp] */
            ii(0x1016_eb96, 4); mov(memd[ss, esp + 12], eax);           /* mov [esp+0xc], eax */
            ii(0x1016_eb9a, 2); cmp(eax, esi);                          /* cmp eax, esi */
            ii(0x1016_eb9c, 2); if(jbe(0x1016_eba2, 4)) goto l_0x1016_eba2; /* jbe 0x1016eba2 */
            ii(0x1016_eb9e, 4); mov(memd[ss, esp + 12], esi);           /* mov [esp+0xc], esi */
        l_0x1016_eba2:
            ii(0x1016_eba2, 4); mov(eax, memd[ss, esp + 12]);           /* mov eax, [esp+0xc] */
            ii(0x1016_eba6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_eba8, 2); if(jbe(0x1016_eb2c, -0x7e)) goto l_0x1016_eb2c; /* jbe 0x1016eb2c */
            ii(0x1016_ebaa, 5); imul(eax, memd[ss, esp + 4]);           /* imul eax, [esp+0x4] */
            ii(0x1016_ebaf, 6); mov(ebx, memd[ds, 0x101b_e1dc]);        /* mov ebx, [0x101be1dc] */
            ii(0x1016_ebb5, 4); mov(memd[ss, esp + 8], eax);            /* mov [esp+0x8], eax */
            ii(0x1016_ebb9, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_ebbb, 6); if(jz(0x1016_ec6e, 0xad)) goto l_0x1016_ec6e; /* jz 0x1016ec6e */
            ii(0x1016_ebc1, 6); mov(edx, memd[ds, 0x101b_e1d8]);        /* mov edx, [0x101be1d8] */
            ii(0x1016_ebc7, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_ebc9, 6); sub(edx, memd[ds, 0x101b_e1d4]);        /* sub edx, [0x101be1d4] */
            ii(0x1016_ebcf, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1016_ebd1, 2); if(ja(0x1016_ec1d, 0x4a)) goto l_0x1016_ec1d; /* ja 0x1016ec1d */
        l_0x1016_ebd3:
            ii(0x1016_ebd3, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1016_ebd5, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1016_ebd7, 3); mov(esi, memd[ss, ebp + 32]);           /* mov esi, [ebp+0x20] */
            ii(0x1016_ebda, 1); push(edi);                              /* push edi */
            ii(0x1016_ebdb, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_ebdd, 3); shr(ecx, 2);                            /* shr ecx, 0x2 */
            ii(0x1016_ebe0, 2); repne(() => movsd());                   /* repne movsd */
            ii(0x1016_ebe2, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_ebe4, 3); and(cl, 3);                             /* and cl, 0x3 */
            ii(0x1016_ebe7, 2); repne(() => movsb());                   /* repne movsb */
            ii(0x1016_ebe9, 1); pop(edi);                               /* pop edi */
            ii(0x1016_ebea, 4); mov(edi, memd[ss, esp + 8]);            /* mov edi, [esp+0x8] */
            ii(0x1016_ebee, 3); mov(ecx, memd[ss, ebp + 32]);           /* mov ecx, [ebp+0x20] */
            ii(0x1016_ebf1, 3); mov(esi, memd[ss, ebp + 16]);           /* mov esi, [ebp+0x10] */
            ii(0x1016_ebf4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_ebf6, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1016_ebf8, 5); mov(memd[ds, 0x101b_e1d4], eax);        /* mov [0x101be1d4], eax */
            ii(0x1016_ebfd, 2); add(ecx, edx);                          /* add ecx, edx */
            ii(0x1016_ebff, 2); sub(esi, edx);                          /* sub esi, edx */
            ii(0x1016_ec01, 3); mov(memd[ss, ebp + 32], ecx);           /* mov [ebp+0x20], ecx */
            ii(0x1016_ec04, 2); sub(edi, edx);                          /* sub edi, edx */
            ii(0x1016_ec06, 3); mov(memd[ss, ebp + 16], esi);           /* mov [ebp+0x10], esi */
            ii(0x1016_ec09, 6); call_abs(memd[ds, 0x101b_e1dc]);        /* call dword [0x101be1dc] */
            ii(0x1016_ec0f, 6); mov(edx, memd[ds, 0x101b_e1d8]);        /* mov edx, [0x101be1d8] */
            ii(0x1016_ec15, 4); mov(memd[ss, esp + 8], edi);            /* mov [esp+0x8], edi */
            ii(0x1016_ec19, 2); cmp(edx, edi);                          /* cmp edx, edi */
            ii(0x1016_ec1b, 2); if(jbe(0x1016_ebd3, -0x4a)) goto l_0x1016_ebd3; /* jbe 0x1016ebd3 */
        l_0x1016_ec1d:
            ii(0x1016_ec1d, 5); cmp(memd[ss, esp + 8], 0);              /* cmp dword [esp+0x8], 0x0 */
            ii(0x1016_ec22, 6); if(jz(0x1016_eb2c, -0xfc)) goto l_0x1016_eb2c; /* jz 0x1016eb2c */
            ii(0x1016_ec28, 4); mov(ecx, memd[ss, esp + 8]);            /* mov ecx, [esp+0x8] */
            ii(0x1016_ec2c, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1016_ec2e, 3); mov(esi, memd[ss, ebp + 32]);           /* mov esi, [ebp+0x20] */
            ii(0x1016_ec31, 1); push(edi);                              /* push edi */
            ii(0x1016_ec32, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_ec34, 3); shr(ecx, 2);                            /* shr ecx, 0x2 */
            ii(0x1016_ec37, 2); repne(() => movsd());                   /* repne movsd */
            ii(0x1016_ec39, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_ec3b, 3); and(cl, 3);                             /* and cl, 0x3 */
            ii(0x1016_ec3e, 2); repne(() => movsb());                   /* repne movsb */
            ii(0x1016_ec40, 1); pop(edi);                               /* pop edi */
            ii(0x1016_ec41, 4); mov(eax, memd[ss, esp + 8]);            /* mov eax, [esp+0x8] */
            ii(0x1016_ec45, 6); mov(ebx, memd[ds, 0x101b_e1d4]);        /* mov ebx, [0x101be1d4] */
            ii(0x1016_ec4b, 3); mov(edi, memd[ss, ebp + 32]);           /* mov edi, [ebp+0x20] */
            ii(0x1016_ec4e, 3); mov(edx, memd[ss, ebp + 16]);           /* mov edx, [ebp+0x10] */
            ii(0x1016_ec51, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1016_ec53, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1016_ec55, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1016_ec57, 3); mov(memd[ss, ebp + 32], edi);           /* mov [ebp+0x20], edi */
            ii(0x1016_ec5a, 6); mov(memd[ds, 0x101b_e1d4], ebx);        /* mov [0x101be1d4], ebx */
            ii(0x1016_ec60, 3); mov(memd[ss, ebp + 16], edx);           /* mov [ebp+0x10], edx */
            ii(0x1016_ec63, 4); mov(eax, memd[ss, esp + 12]);           /* mov eax, [esp+0xc] */
            ii(0x1016_ec67, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1016_ec6a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_ec6b, 1); pop(edi);                               /* pop edi */
            ii(0x1016_ec6c, 1); pop(esi);                               /* pop esi */
            ii(0x1016_ec6d, 1); ret(); return;                          /* ret */
        l_0x1016_ec6e:
            ii(0x1016_ec6e, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_ec70, 3); mov(esi, memd[ss, ebp + 32]);           /* mov esi, [ebp+0x20] */
            ii(0x1016_ec73, 1); push(edi);                              /* push edi */
            ii(0x1016_ec74, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_ec76, 3); shr(ecx, 2);                            /* shr ecx, 0x2 */
            ii(0x1016_ec79, 2); repne(() => movsd());                   /* repne movsd */
            ii(0x1016_ec7b, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_ec7d, 3); and(cl, 3);                             /* and cl, 0x3 */
            ii(0x1016_ec80, 2); repne(() => movsb());                   /* repne movsb */
            ii(0x1016_ec82, 1); pop(edi);                               /* pop edi */
            ii(0x1016_ec83, 4); mov(eax, memd[ss, esp + 8]);            /* mov eax, [esp+0x8] */
            ii(0x1016_ec87, 3); mov(ecx, memd[ss, ebp + 32]);           /* mov ecx, [ebp+0x20] */
            ii(0x1016_ec8a, 3); mov(esi, memd[ss, ebp + 16]);           /* mov esi, [ebp+0x10] */
            ii(0x1016_ec8d, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1016_ec8f, 2); sub(esi, eax);                          /* sub esi, eax */
            ii(0x1016_ec91, 3); mov(memd[ss, ebp + 32], ecx);           /* mov [ebp+0x20], ecx */
            ii(0x1016_ec94, 3); mov(memd[ss, ebp + 16], esi);           /* mov [ebp+0x10], esi */
            ii(0x1016_ec97, 4); mov(eax, memd[ss, esp + 12]);           /* mov eax, [esp+0xc] */
            ii(0x1016_ec9b, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1016_ec9e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_ec9f, 1); pop(edi);                               /* pop edi */
            ii(0x1016_eca0, 1); pop(esi);                               /* pop esi */
            ii(0x1016_eca1, 1); ret(); return;                          /* ret */
        l_0x1016_eca2:
            ii(0x1016_eca2, 3); mov(eax, memd[ds, ecx + 16]);           /* mov eax, [ecx+0x10] */
            ii(0x1016_eca5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_eca7, 6); if(jbe(0x1016_eb2c, -0x181)) goto l_0x1016_eb2c; /* jbe 0x1016eb2c */
            ii(0x1016_ecad, 4); div(memd[ss, esp + 4]);                 /* div dword [esp+0x4] */
            ii(0x1016_ecb1, 3); mov(ecx, memd[ss, esp]);                /* mov ecx, [esp] */
            ii(0x1016_ecb4, 4); mov(memd[ss, esp + 12], eax);           /* mov [esp+0xc], eax */
            ii(0x1016_ecb8, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1016_ecba, 2); if(jbe(0x1016_ecc0, 4)) goto l_0x1016_ecc0; /* jbe 0x1016ecc0 */
            ii(0x1016_ecbc, 4); mov(memd[ss, esp + 12], ecx);           /* mov [esp+0xc], ecx */
        l_0x1016_ecc0:
            ii(0x1016_ecc0, 4); mov(esi, memd[ss, esp + 12]);           /* mov esi, [esp+0xc] */
            ii(0x1016_ecc4, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_ecc6, 6); if(jbe(0x1016_eb2c, -0x1a0)) goto l_0x1016_eb2c; /* jbe 0x1016eb2c */
            ii(0x1016_eccc, 3); mov(eax, memd[ss, ebp]);                /* mov eax, [ebp] */
            ii(0x1016_eccf, 3); mov(edx, memd[ss, ebp + 24]);           /* mov edx, [ebp+0x18] */
            ii(0x1016_ecd2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_ecd4, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1016_ecd7, 5); call(Definitions.sys_fseek, 0x3794);    /* call 0x10172470 */
            ii(0x1016_ecdc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_ecde, 6); if(jnz(0x1016_eb2c, -0x1b8)) goto l_0x1016_eb2c; /* jnz 0x1016eb2c */
            ii(0x1016_ece4, 7); cmp(memd[ds, 0x101b_e1dc], 0);          /* cmp dword [0x101be1dc], 0x0 */
            ii(0x1016_eceb, 6); if(jz(0x1016_edaf, 0xbe)) goto l_0x1016_edaf; /* jz 0x1016edaf */
            ii(0x1016_ecf1, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_ecf4, 2); mov(esi, edi);                          /* mov esi, edi */
            ii(0x1016_ecf6, 4); mov(edi, memd[ss, esp + 4]);            /* mov edi, [esp+0x4] */
            ii(0x1016_ecfa, 3); imul(edi, eax);                         /* imul edi, eax */
            ii(0x1016_ecfd, 6); mov(edx, memd[ds, 0x101b_e1d4]);        /* mov edx, [0x101be1d4] */
            ii(0x1016_ed03, 5); mov(eax, memd[ds, 0x101b_e1d8]);        /* mov eax, [0x101be1d8] */
            ii(0x1016_ed08, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_ed0a, 2); cmp(edi, eax);                          /* cmp edi, eax */
            ii(0x1016_ed0c, 2); if(jl(0x1016_ed47, 0x39)) goto l_0x1016_ed47; /* jl 0x1016ed47 */
        l_0x1016_ed0e:
            ii(0x1016_ed0e, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1016_ed13, 3); mov(ecx, memd[ss, ebp]);                /* mov ecx, [ebp] */
            ii(0x1016_ed16, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_ed18, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_ed1a, 3); mov(ecx, memd[ds, ecx + 4]);            /* mov ecx, [ecx+0x4] */
            ii(0x1016_ed1d, 5); call(Definitions.sys_fread, 0x384a);    /* call 0x1017256c */
            ii(0x1016_ed22, 4); mov(edx, memd[ss, esp + 12]);           /* mov edx, [esp+0xc] */
            ii(0x1016_ed26, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1016_ed28, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_ed2a, 2); sub(edi, eax);                          /* sub edi, eax */
            ii(0x1016_ed2c, 6); mov(memd[ds, 0x101b_e1d4], ebx);        /* mov [0x101be1d4], ebx */
            ii(0x1016_ed32, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_ed34, 6); call_abs(memd[ds, 0x101b_e1dc]);        /* call dword [0x101be1dc] */
            ii(0x1016_ed3a, 5); mov(eax, memd[ds, 0x101b_e1d8]);        /* mov eax, [0x101be1d8] */
            ii(0x1016_ed3f, 4); mov(memd[ss, esp + 12], edx);           /* mov [esp+0xc], edx */
            ii(0x1016_ed43, 2); cmp(edi, eax);                          /* cmp edi, eax */
            ii(0x1016_ed45, 2); if(jge(0x1016_ed0e, -0x39)) goto l_0x1016_ed0e; /* jge 0x1016ed0e */
        l_0x1016_ed47:
            ii(0x1016_ed47, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_ed49, 2); if(jz(0x1016_ed77, 0x2c)) goto l_0x1016_ed77; /* jz 0x1016ed77 */
            ii(0x1016_ed4b, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1016_ed50, 3); mov(ecx, memd[ss, ebp]);                /* mov ecx, [ebp] */
            ii(0x1016_ed53, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_ed55, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_ed57, 3); mov(ecx, memd[ds, ecx + 4]);            /* mov ecx, [ecx+0x4] */
            ii(0x1016_ed5a, 5); call(Definitions.sys_fread, 0x380d);    /* call 0x1017256c */
            ii(0x1016_ed5f, 4); mov(ecx, memd[ss, esp + 12]);           /* mov ecx, [esp+0xc] */
            ii(0x1016_ed63, 6); mov(esi, memd[ds, 0x101b_e1d4]);        /* mov esi, [0x101be1d4] */
            ii(0x1016_ed69, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1016_ed6b, 2); add(esi, edi);                          /* add esi, edi */
            ii(0x1016_ed6d, 4); mov(memd[ss, esp + 12], ecx);           /* mov [esp+0xc], ecx */
            ii(0x1016_ed71, 6); mov(memd[ds, 0x101b_e1d4], esi);        /* mov [0x101be1d4], esi */
        l_0x1016_ed77:
            ii(0x1016_ed77, 3); mov(eax, memd[ss, ebp]);                /* mov eax, [ebp] */
            ii(0x1016_ed7a, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1016_ed7d, 4); mov(edi, memd[ss, esp + 4]);            /* mov edi, [esp+0x4] */
            ii(0x1016_ed81, 5); call(Definitions.sys_ftell, 0x39c1);    /* call 0x10172747 */
            ii(0x1016_ed86, 3); mov(memd[ss, ebp + 24], eax);           /* mov [ebp+0x18], eax */
            ii(0x1016_ed89, 4); mov(eax, memd[ss, esp + 12]);           /* mov eax, [esp+0xc] */
            ii(0x1016_ed8d, 3); imul(eax, edi);                         /* imul eax, edi */
            ii(0x1016_ed90, 3); mov(edx, memd[ss, ebp + 16]);           /* mov edx, [ebp+0x10] */
            ii(0x1016_ed93, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1016_ed95, 4); mov(eax, memd[ss, esp + 12]);           /* mov eax, [esp+0xc] */
            ii(0x1016_ed99, 3); mov(memd[ss, ebp + 16], edx);           /* mov [ebp+0x10], edx */
            ii(0x1016_ed9c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_ed9e, 2); div(edi);                               /* div edi */
            ii(0x1016_eda0, 4); mov(memd[ss, esp + 12], eax);           /* mov [esp+0xc], eax */
            ii(0x1016_eda4, 4); mov(eax, memd[ss, esp + 12]);           /* mov eax, [esp+0xc] */
            ii(0x1016_eda8, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1016_edab, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_edac, 1); pop(edi);                               /* pop edi */
            ii(0x1016_edad, 1); pop(esi);                               /* pop esi */
            ii(0x1016_edae, 1); ret(); return;                          /* ret */
        l_0x1016_edaf:
            ii(0x1016_edaf, 4); mov(edx, memd[ss, esp + 4]);            /* mov edx, [esp+0x4] */
            ii(0x1016_edb3, 3); mov(ecx, memd[ss, ebp]);                /* mov ecx, [ebp] */
            ii(0x1016_edb6, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1016_edb8, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_edba, 3); mov(ecx, memd[ds, ecx + 4]);            /* mov ecx, [ecx+0x4] */
            ii(0x1016_edbd, 5); call(Definitions.sys_fread, 0x37aa);    /* call 0x1017256c */
            ii(0x1016_edc2, 4); mov(ebx, memd[ss, esp + 4]);            /* mov ebx, [esp+0x4] */
            ii(0x1016_edc6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_edc8, 3); imul(edx, ebx);                         /* imul edx, ebx */
            ii(0x1016_edcb, 4); mov(memd[ss, esp + 12], eax);           /* mov [esp+0xc], eax */
            ii(0x1016_edcf, 3); mov(eax, memd[ss, ebp]);                /* mov eax, [ebp] */
            ii(0x1016_edd2, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1016_edd5, 5); call(Definitions.sys_ftell, 0x396d);    /* call 0x10172747 */
            ii(0x1016_edda, 3); mov(ecx, memd[ss, ebp + 16]);           /* mov ecx, [ebp+0x10] */
            ii(0x1016_eddd, 3); mov(memd[ss, ebp + 24], eax);           /* mov [ebp+0x18], eax */
            ii(0x1016_ede0, 2); sub(ecx, edx);                          /* sub ecx, edx */
            ii(0x1016_ede2, 3); mov(memd[ss, ebp + 16], ecx);           /* mov [ebp+0x10], ecx */
            ii(0x1016_ede5, 4); mov(eax, memd[ss, esp + 12]);           /* mov eax, [esp+0xc] */
            ii(0x1016_ede9, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1016_edec, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_eded, 1); pop(edi);                               /* pop edi */
            ii(0x1016_edee, 1); pop(esi);                               /* pop esi */
            ii(0x1016_edef, 1); ret(); return;                          /* ret */
        l_0x1016_edf0:
            ii(0x1016_edf0, 3); mov(ebx, memd[ds, ecx + 16]);           /* mov ebx, [ecx+0x10] */
            ii(0x1016_edf3, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_edf5, 6); if(jbe(0x1016_eb2c, -0x2cf)) goto l_0x1016_eb2c; /* jbe 0x1016eb2c */
            ii(0x1016_edfb, 4); mov(ecx, memd[ss, esp + 4]);            /* mov ecx, [esp+0x4] */
            ii(0x1016_edff, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_ee01, 2); div(ecx);                               /* div ecx */
            ii(0x1016_ee03, 3); mov(esi, memd[ss, esp]);                /* mov esi, [esp] */
            ii(0x1016_ee06, 4); mov(memd[ss, esp + 12], eax);           /* mov [esp+0xc], eax */
            ii(0x1016_ee0a, 2); cmp(eax, esi);                          /* cmp eax, esi */
            ii(0x1016_ee0c, 2); if(jbe(0x1016_ee12, 4)) goto l_0x1016_ee12; /* jbe 0x1016ee12 */
            ii(0x1016_ee0e, 4); mov(memd[ss, esp + 12], esi);           /* mov [esp+0xc], esi */
        l_0x1016_ee12:
            ii(0x1016_ee12, 4); mov(eax, memd[ss, esp + 12]);           /* mov eax, [esp+0xc] */
            ii(0x1016_ee16, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_ee18, 6); if(jbe(0x1016_eb2c, -0x2f2)) goto l_0x1016_eb2c; /* jbe 0x1016eb2c */
            ii(0x1016_ee1e, 4); mov(ecx, memd[ss, esp + 4]);            /* mov ecx, [esp+0x4] */
            ii(0x1016_ee22, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_ee24, 3); imul(edx, ecx);                         /* imul edx, ecx */
            ii(0x1016_ee27, 6); mov(esi, memd[ds, 0x101b_e1dc]);        /* mov esi, [0x101be1dc] */
            ii(0x1016_ee2d, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_ee2f, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_ee31, 6); if(jz(0x1016_ef7f, 0x148)) goto l_0x1016_ef7f; /* jz 0x1016ef7f */
            ii(0x1016_ee37, 6); mov(esi, memd[ds, 0x101b_e1d8]);        /* mov esi, [0x101be1d8] */
            ii(0x1016_ee3d, 6); sub(esi, memd[ds, 0x101b_e1d4]);        /* sub esi, [0x101be1d4] */
            ii(0x1016_ee43, 2); cmp(edx, esi);                          /* cmp edx, esi */
            ii(0x1016_ee45, 6); if(jb(0x1016_eed7, 0x8c)) goto l_0x1016_eed7; /* jb 0x1016eed7 */
        l_0x1016_ee4b:
            ii(0x1016_ee4b, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_ee4d, 5); call(/* sys */ 0x1017_11bc, 0x236a);    /* call 0x101711bc */
            ii(0x1016_ee52, 3); mov(eax, memd[ss, ebp + 28]);           /* mov eax, [ebp+0x1c] */
            ii(0x1016_ee55, 3); mov(ecx, memd[ss, ebp + 32]);           /* mov ecx, [ebp+0x20] */
            ii(0x1016_ee58, 5); add(eax, 0x4000);                       /* add eax, 0x4000 */
            ii(0x1016_ee5d, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_ee5f, 2); cmp(esi, eax);                          /* cmp esi, eax */
            ii(0x1016_ee61, 2); if(jae(0x1016_ee69, 6)) goto l_0x1016_ee69; /* jae 0x1016ee69 */
            ii(0x1016_ee63, 4); mov(memd[ss, esp + 20], esi);           /* mov [esp+0x14], esi */
            ii(0x1016_ee67, 2); jmp(0x1016_ee6d, 4); goto l_0x1016_ee6d; /* jmp 0x1016ee6d */
        l_0x1016_ee69:
            ii(0x1016_ee69, 4); mov(memd[ss, esp + 20], eax);           /* mov [esp+0x14], eax */
        l_0x1016_ee6d:
            ii(0x1016_ee6d, 4); mov(ecx, memd[ss, esp + 20]);           /* mov ecx, [esp+0x14] */
            ii(0x1016_ee71, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1016_ee73, 3); mov(esi, memd[ss, ebp + 32]);           /* mov esi, [ebp+0x20] */
            ii(0x1016_ee76, 1); push(edi);                              /* push edi */
            ii(0x1016_ee77, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_ee79, 3); shr(ecx, 2);                            /* shr ecx, 0x2 */
            ii(0x1016_ee7c, 2); repne(() => movsd());                   /* repne movsd */
            ii(0x1016_ee7e, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_ee80, 3); and(cl, 3);                             /* and cl, 0x3 */
            ii(0x1016_ee83, 2); repne(() => movsb());                   /* repne movsb */
            ii(0x1016_ee85, 1); pop(edi);                               /* pop edi */
            ii(0x1016_ee86, 4); mov(eax, memd[ss, esp + 20]);           /* mov eax, [esp+0x14] */
            ii(0x1016_ee8a, 6); mov(edi, memd[ds, 0x101b_e1d8]);        /* mov edi, [0x101be1d8] */
            ii(0x1016_ee90, 3); mov(esi, memd[ss, ebp + 32]);           /* mov esi, [ebp+0x20] */
            ii(0x1016_ee93, 3); mov(ecx, memd[ss, ebp + 16]);           /* mov ecx, [ebp+0x10] */
            ii(0x1016_ee96, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1016_ee98, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1016_ee9a, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1016_ee9c, 3); mov(memd[ss, ebp + 32], esi);           /* mov [ebp+0x20], esi */
            ii(0x1016_ee9f, 6); mov(esi, memd[ds, 0x101b_e1d4]);        /* mov esi, [0x101be1d4] */
            ii(0x1016_eea5, 2); sub(ecx, eax);                          /* sub ecx, eax */
            ii(0x1016_eea7, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1016_eea9, 3); mov(memd[ss, ebp + 16], ecx);           /* mov [ebp+0x10], ecx */
            ii(0x1016_eeac, 6); mov(memd[ds, 0x101b_e1d4], esi);        /* mov [0x101be1d4], esi */
            ii(0x1016_eeb2, 2); cmp(esi, edi);                          /* cmp esi, edi */
            ii(0x1016_eeb4, 2); if(jb(0x1016_eec3, 0xd)) goto l_0x1016_eec3; /* jb 0x1016eec3 */
            ii(0x1016_eeb6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_eeb8, 5); mov(memd[ds, 0x101b_e1d4], eax);        /* mov [0x101be1d4], eax */
            ii(0x1016_eebd, 6); call_abs(memd[ds, 0x101b_e1dc]);        /* call dword [0x101be1dc] */
        l_0x1016_eec3:
            ii(0x1016_eec3, 6); mov(esi, memd[ds, 0x101b_e1d8]);        /* mov esi, [0x101be1d8] */
            ii(0x1016_eec9, 6); sub(esi, memd[ds, 0x101b_e1d4]);        /* sub esi, [0x101be1d4] */
            ii(0x1016_eecf, 2); cmp(edx, esi);                          /* cmp edx, esi */
            ii(0x1016_eed1, 6); if(jae(0x1016_ee4b, -0x8c)) goto l_0x1016_ee4b; /* jae 0x1016ee4b */
        l_0x1016_eed7:
            ii(0x1016_eed7, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_eed9, 6); if(jz(0x1016_eb2c, -0x3b3)) goto l_0x1016_eb2c; /* jz 0x1016eb2c */
        l_0x1016_eedf:
            ii(0x1016_eedf, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_eee1, 6); if(jz(0x1016_eb2c, -0x3bb)) goto l_0x1016_eb2c; /* jz 0x1016eb2c */
            ii(0x1016_eee7, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_eee9, 5); call(/* sys */ 0x1017_11bc, 0x22ce);    /* call 0x101711bc */
            ii(0x1016_eeee, 3); mov(eax, memd[ss, ebp + 28]);           /* mov eax, [ebp+0x1c] */
            ii(0x1016_eef1, 3); mov(ecx, memd[ss, ebp + 32]);           /* mov ecx, [ebp+0x20] */
            ii(0x1016_eef4, 5); add(eax, 0x4000);                       /* add eax, 0x4000 */
            ii(0x1016_eef9, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_eefb, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1016_eefd, 2); if(jae(0x1016_ef05, 6)) goto l_0x1016_ef05; /* jae 0x1016ef05 */
            ii(0x1016_eeff, 4); mov(memd[ss, esp + 24], edx);           /* mov [esp+0x18], edx */
            ii(0x1016_ef03, 2); jmp(0x1016_ef09, 4); goto l_0x1016_ef09; /* jmp 0x1016ef09 */
        l_0x1016_ef05:
            ii(0x1016_ef05, 4); mov(memd[ss, esp + 24], eax);           /* mov [esp+0x18], eax */
        l_0x1016_ef09:
            ii(0x1016_ef09, 4); mov(ecx, memd[ss, esp + 24]);           /* mov ecx, [esp+0x18] */
            ii(0x1016_ef0d, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1016_ef0f, 3); mov(esi, memd[ss, ebp + 32]);           /* mov esi, [ebp+0x20] */
            ii(0x1016_ef12, 1); push(edi);                              /* push edi */
            ii(0x1016_ef13, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_ef15, 3); shr(ecx, 2);                            /* shr ecx, 0x2 */
            ii(0x1016_ef18, 2); repne(() => movsd());                   /* repne movsd */
            ii(0x1016_ef1a, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_ef1c, 3); and(cl, 3);                             /* and cl, 0x3 */
            ii(0x1016_ef1f, 2); repne(() => movsb());                   /* repne movsb */
            ii(0x1016_ef21, 1); pop(edi);                               /* pop edi */
            ii(0x1016_ef22, 4); mov(eax, memd[ss, esp + 24]);           /* mov eax, [esp+0x18] */
            ii(0x1016_ef26, 6); mov(ecx, memd[ds, 0x101b_e1d4]);        /* mov ecx, [0x101be1d4] */
            ii(0x1016_ef2c, 3); mov(esi, memd[ss, ebp + 32]);           /* mov esi, [ebp+0x20] */
            ii(0x1016_ef2f, 3); mov(edi, memd[ss, ebp + 16]);           /* mov edi, [ebp+0x10] */
            ii(0x1016_ef32, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1016_ef34, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1016_ef36, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1016_ef38, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1016_ef3a, 2); sub(edi, eax);                          /* sub edi, eax */
            ii(0x1016_ef3c, 3); mov(memd[ss, ebp + 32], esi);           /* mov [ebp+0x20], esi */
            ii(0x1016_ef3f, 6); mov(memd[ds, 0x101b_e1d4], ecx);        /* mov [0x101be1d4], ecx */
            ii(0x1016_ef45, 3); mov(memd[ss, ebp + 16], edi);           /* mov [ebp+0x10], edi */
            ii(0x1016_ef48, 2); jmp(0x1016_eedf, -0x6b); goto l_0x1016_eedf; /* jmp 0x1016eedf */
        l_0x1016_ef4a:
            ii(0x1016_ef4a, 4); mov(memd[ss, esp + 16], eax);           /* mov [esp+0x10], eax */
        l_0x1016_ef4e:
            ii(0x1016_ef4e, 4); mov(ecx, memd[ss, esp + 16]);           /* mov ecx, [esp+0x10] */
            ii(0x1016_ef52, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1016_ef54, 3); mov(esi, memd[ss, ebp + 32]);           /* mov esi, [ebp+0x20] */
            ii(0x1016_ef57, 1); push(edi);                              /* push edi */
            ii(0x1016_ef58, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_ef5a, 3); shr(ecx, 2);                            /* shr ecx, 0x2 */
            ii(0x1016_ef5d, 2); repne(() => movsd());                   /* repne movsd */
            ii(0x1016_ef5f, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_ef61, 3); and(cl, 3);                             /* and cl, 0x3 */
            ii(0x1016_ef64, 2); repne(() => movsb());                   /* repne movsb */
            ii(0x1016_ef66, 1); pop(edi);                               /* pop edi */
            ii(0x1016_ef67, 4); mov(eax, memd[ss, esp + 16]);           /* mov eax, [esp+0x10] */
            ii(0x1016_ef6b, 3); mov(edi, memd[ss, ebp + 32]);           /* mov edi, [ebp+0x20] */
            ii(0x1016_ef6e, 3); mov(esi, memd[ss, ebp + 16]);           /* mov esi, [ebp+0x10] */
            ii(0x1016_ef71, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1016_ef73, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1016_ef75, 2); sub(esi, eax);                          /* sub esi, eax */
            ii(0x1016_ef77, 3); mov(memd[ss, ebp + 32], edi);           /* mov [ebp+0x20], edi */
            ii(0x1016_ef7a, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1016_ef7c, 3); mov(memd[ss, ebp + 16], esi);           /* mov [ebp+0x10], esi */
        l_0x1016_ef7f:
            ii(0x1016_ef7f, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_ef81, 6); if(jz(0x1016_eb2c, -0x45b)) goto l_0x1016_eb2c; /* jz 0x1016eb2c */
            ii(0x1016_ef87, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_ef89, 5); call(/* sys */ 0x1017_11bc, 0x222e);    /* call 0x101711bc */
            ii(0x1016_ef8e, 3); mov(eax, memd[ss, ebp + 28]);           /* mov eax, [ebp+0x1c] */
            ii(0x1016_ef91, 3); mov(esi, memd[ss, ebp + 32]);           /* mov esi, [ebp+0x20] */
            ii(0x1016_ef94, 5); add(eax, 0x4000);                       /* add eax, 0x4000 */
            ii(0x1016_ef99, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1016_ef9b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1016_ef9d, 2); if(jae(0x1016_ef4a, -0x55)) goto l_0x1016_ef4a; /* jae 0x1016ef4a */
            ii(0x1016_ef9f, 4); mov(memd[ss, esp + 16], edx);           /* mov [esp+0x10], edx */
            ii(0x1016_efa3, 2); jmp(0x1016_ef4e, -0x57); goto l_0x1016_ef4e; /* jmp 0x1016ef4e */
        }
    }
}
