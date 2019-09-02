using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_acc6-a5bce7f8")]
        public void /* sys */ Method_1019_acc6()
        {
            ii(0x1019_acc6, 1); push(ebx);                              /* push ebx */
            ii(0x1019_acc7, 1); push(ecx);                              /* push ecx */
            ii(0x1019_acc8, 1); push(edx);                              /* push edx */
            ii(0x1019_acc9, 1); push(esi);                              /* push esi */
            ii(0x1019_acca, 1); push(edi);                              /* push edi */
            ii(0x1019_accb, 1); push(ebp);                              /* push ebp */
            ii(0x1019_accc, 3); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1019_accf, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_acd1, 5); mov(eax, memd[ds, 0x101c_1cee]);        /* mov eax, [0x101c1cee] */
            ii(0x1019_acd6, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1019_acd8, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1019_acda, 2); test(dl, dl);                           /* test dl, dl */
            ii(0x1019_acdc, 6); if(jz(0x1019_af7a, 0x298)) goto l_0x1019_af7a; /* jz 0x1019af7a */
            ii(0x1019_ace2, 5); mov(edx, 0x101c_1c7c);                  /* mov edx, 0x101c1c7c */
            ii(0x1019_ace7, 5); mov(eax, 0x101c_1c58);                  /* mov eax, 0x101c1c58 */
            ii(0x1019_acec, 3); mov(ebx, memd[ds, ecx + 20]);           /* mov ebx, [ecx+0x14] */
            ii(0x1019_acef, 5); call(/* sys */ 0x1019_ac92, -0x62);     /* call 0x1019ac92 */
            ii(0x1019_acf4, 4); mov(memd[ss, esp + 20], eax);           /* mov [esp+0x14], eax */
            ii(0x1019_acf8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_acfa, 2); if(jz(0x1019_ad08, 0xc)) goto l_0x1019_ad08; /* jz 0x1019ad08 */
            ii(0x1019_acfc, 5); mov(esi, 0x101c_1c7c);                  /* mov esi, 0x101c1c7c */
            ii(0x1019_ad01, 5); mov(ebx, 0x101c_1c58);                  /* mov ebx, 0x101c1c58 */
            ii(0x1019_ad06, 2); jmp(0x1019_ad12, 0xa); goto l_0x1019_ad12; /* jmp 0x1019ad12 */
        l_0x1019_ad08:
            ii(0x1019_ad08, 5); mov(esi, 0x101c_1c58);                  /* mov esi, 0x101c1c58 */
            ii(0x1019_ad0d, 5); mov(ebx, 0x101c_1c7c);                  /* mov ebx, 0x101c1c7c */
        l_0x1019_ad12:
            ii(0x1019_ad12, 3); mov(eax, memd[ds, ecx + 20]);           /* mov eax, [ecx+0x14] */
            ii(0x1019_ad15, 5); add(eax, 0x76c);                        /* add eax, 0x76c */
            ii(0x1019_ad1a, 3); mov(ebp, memd[ds, ecx + 16]);           /* mov ebp, [ecx+0x10] */
            ii(0x1019_ad1d, 5); call(/* sys */ 0x1019_ab72, -0x1b0);    /* call 0x1019ab72 */
            ii(0x1019_ad22, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_ad24, 4); lea(eax, memd[ss, ebp + ebp]);          /* lea eax, [ebp+ebp] */
            ii(0x1019_ad28, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1019_ad2a, 2); if(jz(0x1019_ad3a, 0xe)) goto l_0x1019_ad3a; /* jz 0x1019ad3a */
            ii(0x1019_ad2c, 6); mov(edx, memd[ds, eax + 0x101b_76e6]);  /* mov edx, [eax+0x101b76e6] */
            ii(0x1019_ad32, 6); mov(eax, memd[ds, eax + 0x101b_76e4]);  /* mov eax, [eax+0x101b76e4] */
            ii(0x1019_ad38, 2); jmp(0x1019_ad46, 0xc); goto l_0x1019_ad46; /* jmp 0x1019ad46 */
        l_0x1019_ad3a:
            ii(0x1019_ad3a, 6); mov(edx, memd[ds, eax + 0x101b_76cc]);  /* mov edx, [eax+0x101b76cc] */
            ii(0x1019_ad40, 6); mov(eax, memd[ds, eax + 0x101b_76ca]);  /* mov eax, [eax+0x101b76ca] */
        l_0x1019_ad46:
            ii(0x1019_ad46, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1019_ad49, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1019_ad4c, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1019_ad4e, 4); mov(memd[ss, esp + 12], edx);           /* mov [esp+0xc], edx */
            ii(0x1019_ad52, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_ad54, 3); mov(eax, memd[ds, esi + 32]);           /* mov eax, [esi+0x20] */
            ii(0x1019_ad57, 4); mov(memd[ss, esp + 16], edx);           /* mov [esp+0x10], edx */
            ii(0x1019_ad5b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_ad5d, 6); if(jnz(0x1019_ae16, 0xb3)) goto l_0x1019_ae16; /* jnz 0x1019ae16 */
            ii(0x1019_ad63, 3); mov(eax, memd[ds, esi + 16]);           /* mov eax, [esi+0x10] */
            ii(0x1019_ad66, 2); cmp(ebp, eax);                          /* cmp ebp, eax */
            ii(0x1019_ad68, 2); if(jle(0x1019_ad74, 0xa)) goto l_0x1019_ad74; /* jle 0x1019ad74 */
            ii(0x1019_ad6a, 5); mov(edi, 1);                            /* mov edi, 0x1 */
            ii(0x1019_ad6f, 5); jmp(0x1019_ae4f, 0xdb); goto l_0x1019_ae4f; /* jmp 0x1019ae4f */
        l_0x1019_ad74:
            ii(0x1019_ad74, 6); if(jnz(0x1019_ae4f, 0xd5)) goto l_0x1019_ae4f; /* jnz 0x1019ae4f */
            ii(0x1019_ad7a, 3); mov(edx, memd[ds, ecx + 24]);           /* mov edx, [ecx+0x18] */
            ii(0x1019_ad7d, 3); mov(eax, memd[ds, esi + 24]);           /* mov eax, [esi+0x18] */
            ii(0x1019_ad80, 3); add(edx, 7);                            /* add edx, 0x7 */
            ii(0x1019_ad83, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1019_ad85, 8); mov(memd[ss, esp + 24], 7);             /* mov dword [esp+0x18], 0x7 */
            ii(0x1019_ad8d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_ad8f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_ad92, 4); idiv(memd[ss, esp + 24]);               /* idiv dword [esp+0x18] */
            ii(0x1019_ad96, 3); mov(eax, memd[ds, ecx + 12]);           /* mov eax, [ecx+0xc] */
            ii(0x1019_ad99, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1019_ad9b, 3); mov(edx, memd[ds, ecx + 24]);           /* mov edx, [ecx+0x18] */
            ii(0x1019_ad9e, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1019_ada1, 3); add(edx, 6);                            /* add edx, 0x6 */
            ii(0x1019_ada4, 3); sub(edx, memd[ds, esi + 24]);           /* sub edx, [esi+0x18] */
            ii(0x1019_ada7, 8); mov(memd[ss, esp + 24], 7);             /* mov dword [esp+0x18], 0x7 */
            ii(0x1019_adaf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_adb1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_adb4, 4); idiv(memd[ss, esp + 24]);               /* idiv dword [esp+0x18] */
            ii(0x1019_adb8, 3); mov(eax, memd[ds, ecx + 12]);           /* mov eax, [ecx+0xc] */
            ii(0x1019_adbb, 1); dec(eax);                               /* dec eax */
            ii(0x1019_adbc, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1019_adbe, 3); mov(edx, memd[ds, esi + 12]);           /* mov edx, [esi+0xc] */
            ii(0x1019_adc1, 4); mov(memd[ss, esp + 8], eax);            /* mov [esp+0x8], eax */
            ii(0x1019_adc5, 3); cmp(edx, 5);                            /* cmp edx, 0x5 */
            ii(0x1019_adc8, 2); if(jnz(0x1019_adef, 0x25)) goto l_0x1019_adef; /* jnz 0x1019adef */
            ii(0x1019_adca, 4); mov(eax, memd[ss, esp + 12]);           /* mov eax, [esp+0xc] */
            ii(0x1019_adce, 3); mov(edx, memd[ss, esp]);                /* mov edx, [esp] */
            ii(0x1019_add1, 3); sub(eax, 7);                            /* sub eax, 0x7 */
            ii(0x1019_add4, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1019_add6, 6); if(jge(0x1019_ae4f, 0x73)) goto l_0x1019_ae4f; /* jge 0x1019ae4f */
            ii(0x1019_addc, 4); mov(edx, memd[ss, esp + 8]);            /* mov edx, [esp+0x8] */
            ii(0x1019_ade0, 5); mov(edi, 1);                            /* mov edi, 0x1 */
            ii(0x1019_ade5, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1019_ade7, 6); if(jl(0x1019_ae4f, 0x62)) goto l_0x1019_ae4f; /* jl 0x1019ae4f */
            ii(0x1019_aded, 2); jmp(0x1019_ae4b, 0x5c); goto l_0x1019_ae4b; /* jmp 0x1019ae4b */
        l_0x1019_adef:
            ii(0x1019_adef, 3); lea(eax, memd[ds, edx - 1]);            /* lea eax, [edx-0x1] */
            ii(0x1019_adf2, 4); mov(memd[ss, esp + 24], eax);           /* mov [esp+0x18], eax */
            ii(0x1019_adf6, 4); mov(edx, memd[ss, esp + 24]);           /* mov edx, [esp+0x18] */
            ii(0x1019_adfa, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1019_adfd, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1019_adff, 3); mov(edx, memd[ss, esp]);                /* mov edx, [esp] */
            ii(0x1019_ae02, 1); inc(eax);                               /* inc eax */
            ii(0x1019_ae03, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1019_ae05, 2); if(jg(0x1019_ae4f, 0x48)) goto l_0x1019_ae4f; /* jg 0x1019ae4f */
            ii(0x1019_ae07, 4); mov(edx, memd[ss, esp + 8]);            /* mov edx, [esp+0x8] */
            ii(0x1019_ae0b, 5); mov(edi, 1);                            /* mov edi, 0x1 */
            ii(0x1019_ae10, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1019_ae12, 2); if(jle(0x1019_ae4f, 0x3b)) goto l_0x1019_ae4f; /* jle 0x1019ae4f */
            ii(0x1019_ae14, 2); jmp(0x1019_ae4b, 0x35); goto l_0x1019_ae4b; /* jmp 0x1019ae4b */
        l_0x1019_ae16:
            ii(0x1019_ae16, 3); mov(edx, memd[ds, esi + 28]);           /* mov edx, [esi+0x1c] */
            ii(0x1019_ae19, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1019_ae1c, 2); if(jnz(0x1019_ae3d, 0x1f)) goto l_0x1019_ae3d; /* jnz 0x1019ae3d */
            ii(0x1019_ae1e, 3); mov(eax, memd[ds, ecx + 20]);           /* mov eax, [ecx+0x14] */
            ii(0x1019_ae21, 5); add(eax, 0x76c);                        /* add eax, 0x76c */
            ii(0x1019_ae26, 5); call(/* sys */ 0x1019_ab72, -0x2b9);    /* call 0x1019ab72 */
            ii(0x1019_ae2b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_ae2d, 2); if(jz(0x1019_ae3c, 0xd)) goto l_0x1019_ae3c; /* jz 0x1019ae3c */
            ii(0x1019_ae2f, 5); mov(eax, memd[ds, 0x101b_76ce]);        /* mov eax, [0x101b76ce] */
            ii(0x1019_ae34, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1019_ae37, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1019_ae39, 2); if(jle(0x1019_ae3c, 1)) goto l_0x1019_ae3c; /* jle 0x1019ae3c */
            ii(0x1019_ae3b, 1); inc(edx);                               /* inc edx */
        l_0x1019_ae3c:
            ii(0x1019_ae3c, 1); dec(edx);                               /* dec edx */
        l_0x1019_ae3d:
            ii(0x1019_ae3d, 3); mov(eax, memd[ds, ecx + 28]);           /* mov eax, [ecx+0x1c] */
            ii(0x1019_ae40, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1019_ae42, 2); if(jg(0x1019_ae4f, 0xb)) goto l_0x1019_ae4f; /* jg 0x1019ae4f */
            ii(0x1019_ae44, 5); mov(edi, 1);                            /* mov edi, 0x1 */
            ii(0x1019_ae49, 2); if(jnz(0x1019_ae4f, 4)) goto l_0x1019_ae4f; /* jnz 0x1019ae4f */
        l_0x1019_ae4b:
            ii(0x1019_ae4b, 4); mov(memd[ss, esp + 16], edi);           /* mov [esp+0x10], edi */
        l_0x1019_ae4f:
            ii(0x1019_ae4f, 5); cmp(memd[ss, esp + 16], 0);             /* cmp dword [esp+0x10], 0x0 */
            ii(0x1019_ae54, 2); if(jz(0x1019_ae6c, 0x16)) goto l_0x1019_ae6c; /* jz 0x1019ae6c */
            ii(0x1019_ae56, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1019_ae58, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_ae5a, 5); call(/* sys */ 0x1019_af89, 0x12a);     /* call 0x1019af89 */
            ii(0x1019_ae5f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_ae61, 3); setz(al);                               /* setz al */
            ii(0x1019_ae64, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1019_ae66, 6); and(edi, 0xff);                         /* and edi, 0xff */
        l_0x1019_ae6c:
            ii(0x1019_ae6c, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1019_ae6e, 2); if(jnz(0x1019_ae83, 0x13)) goto l_0x1019_ae83; /* jnz 0x1019ae83 */
            ii(0x1019_ae70, 4); mov(edx, memd[ss, esp + 20]);           /* mov edx, [esp+0x14] */
            ii(0x1019_ae74, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1019_ae76, 6); if(jz(0x1019_af7a, 0xfe)) goto l_0x1019_af7a; /* jz 0x1019af7a */
            ii(0x1019_ae7c, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1019_ae7e, 5); jmp(0x1019_af7a, 0xf7); goto l_0x1019_af7a; /* jmp 0x1019af7a */
        l_0x1019_ae83:
            ii(0x1019_ae83, 3); mov(eax, memd[ds, ebx + 32]);           /* mov eax, [ebx+0x20] */
            ii(0x1019_ae86, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1019_ae88, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_ae8a, 6); if(jnz(0x1019_af26, 0x96)) goto l_0x1019_af26; /* jnz 0x1019af26 */
            ii(0x1019_ae90, 3); mov(eax, memd[ds, ebx + 16]);           /* mov eax, [ebx+0x10] */
            ii(0x1019_ae93, 2); cmp(ebp, eax);                          /* cmp ebp, eax */
            ii(0x1019_ae95, 2); if(jle(0x1019_ae9e, 7)) goto l_0x1019_ae9e; /* jle 0x1019ae9e */
            ii(0x1019_ae97, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1019_ae99, 5); jmp(0x1019_af5f, 0xc1); goto l_0x1019_af5f; /* jmp 0x1019af5f */
        l_0x1019_ae9e:
            ii(0x1019_ae9e, 6); if(jnz(0x1019_af5f, 0xbb)) goto l_0x1019_af5f; /* jnz 0x1019af5f */
            ii(0x1019_aea4, 3); mov(edx, memd[ds, ecx + 24]);           /* mov edx, [ecx+0x18] */
            ii(0x1019_aea7, 3); mov(ebp, memd[ds, ebx + 24]);           /* mov ebp, [ebx+0x18] */
            ii(0x1019_aeaa, 3); add(edx, 7);                            /* add edx, 0x7 */
            ii(0x1019_aead, 2); sub(edx, ebp);                          /* sub edx, ebp */
            ii(0x1019_aeaf, 5); mov(ebp, 7);                            /* mov ebp, 0x7 */
            ii(0x1019_aeb4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_aeb6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_aeb9, 2); idiv(ebp);                              /* idiv ebp */
            ii(0x1019_aebb, 3); mov(eax, memd[ds, ecx + 12]);           /* mov eax, [ecx+0xc] */
            ii(0x1019_aebe, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1019_aec0, 3); mov(edx, memd[ds, ecx + 24]);           /* mov edx, [ecx+0x18] */
            ii(0x1019_aec3, 4); mov(memd[ss, esp + 4], eax);            /* mov [esp+0x4], eax */
            ii(0x1019_aec7, 3); add(edx, 6);                            /* add edx, 0x6 */
            ii(0x1019_aeca, 3); mov(eax, memd[ds, ebx + 24]);           /* mov eax, [ebx+0x18] */
            ii(0x1019_aecd, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1019_aecf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_aed1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_aed4, 2); idiv(ebp);                              /* idiv ebp */
            ii(0x1019_aed6, 3); mov(eax, memd[ds, ecx + 12]);           /* mov eax, [ecx+0xc] */
            ii(0x1019_aed9, 1); dec(eax);                               /* dec eax */
            ii(0x1019_aeda, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1019_aedc, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1019_aede, 3); mov(ebp, memd[ds, ebx + 12]);           /* mov ebp, [ebx+0xc] */
            ii(0x1019_aee1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_aee3, 3); cmp(ebp, 5);                            /* cmp ebp, 0x5 */
            ii(0x1019_aee6, 2); if(jnz(0x1019_af07, 0x1f)) goto l_0x1019_af07; /* jnz 0x1019af07 */
            ii(0x1019_aee8, 4); mov(eax, memd[ss, esp + 12]);           /* mov eax, [esp+0xc] */
            ii(0x1019_aeec, 4); mov(ebp, memd[ss, esp + 4]);            /* mov ebp, [esp+0x4] */
            ii(0x1019_aef0, 3); sub(eax, 7);                            /* sub eax, 0x7 */
            ii(0x1019_aef3, 2); cmp(eax, ebp);                          /* cmp eax, ebp */
            ii(0x1019_aef5, 2); if(jl(0x1019_af01, 0xa)) goto l_0x1019_af01; /* jl 0x1019af01 */
        l_0x1019_aef7:
            ii(0x1019_aef7, 5); mov(edi, 1);                            /* mov edi, 0x1 */
            ii(0x1019_aefc, 5); jmp(0x1019_af5f, 0x5e); goto l_0x1019_af5f; /* jmp 0x1019af5f */
        l_0x1019_af01:
            ii(0x1019_af01, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1019_af03, 2); if(jg(0x1019_af5f, 0x5a)) goto l_0x1019_af5f; /* jg 0x1019af5f */
            ii(0x1019_af05, 2); jmp(0x1019_af5a, 0x53); goto l_0x1019_af5a; /* jmp 0x1019af5a */
        l_0x1019_af07:
            ii(0x1019_af07, 3); lea(eax, memd[ss, ebp - 1]);            /* lea eax, [ebp-0x1] */
            ii(0x1019_af0a, 4); mov(memd[ss, esp + 24], eax);           /* mov [esp+0x18], eax */
            ii(0x1019_af0e, 4); mov(ebp, memd[ss, esp + 24]);           /* mov ebp, [esp+0x18] */
            ii(0x1019_af12, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1019_af15, 2); sub(eax, ebp);                          /* sub eax, ebp */
            ii(0x1019_af17, 4); mov(ebp, memd[ss, esp + 4]);            /* mov ebp, [esp+0x4] */
            ii(0x1019_af1b, 1); inc(eax);                               /* inc eax */
            ii(0x1019_af1c, 2); cmp(eax, ebp);                          /* cmp eax, ebp */
            ii(0x1019_af1e, 2); if(jg(0x1019_aef7, -0x29)) goto l_0x1019_aef7; /* jg 0x1019aef7 */
            ii(0x1019_af20, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1019_af22, 2); if(jge(0x1019_af5f, 0x3b)) goto l_0x1019_af5f; /* jge 0x1019af5f */
            ii(0x1019_af24, 2); jmp(0x1019_af5a, 0x34); goto l_0x1019_af5a; /* jmp 0x1019af5a */
        l_0x1019_af26:
            ii(0x1019_af26, 3); mov(edx, memd[ds, ebx + 28]);           /* mov edx, [ebx+0x1c] */
            ii(0x1019_af29, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1019_af2c, 2); if(jnz(0x1019_af4d, 0x1f)) goto l_0x1019_af4d; /* jnz 0x1019af4d */
            ii(0x1019_af2e, 3); mov(eax, memd[ds, ecx + 20]);           /* mov eax, [ecx+0x14] */
            ii(0x1019_af31, 5); add(eax, 0x76c);                        /* add eax, 0x76c */
            ii(0x1019_af36, 5); call(/* sys */ 0x1019_ab72, -0x3c9);    /* call 0x1019ab72 */
            ii(0x1019_af3b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_af3d, 2); if(jz(0x1019_af4c, 0xd)) goto l_0x1019_af4c; /* jz 0x1019af4c */
            ii(0x1019_af3f, 5); mov(eax, memd[ds, 0x101b_76ce]);        /* mov eax, [0x101b76ce] */
            ii(0x1019_af44, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1019_af47, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1019_af49, 2); if(jle(0x1019_af4c, 1)) goto l_0x1019_af4c; /* jle 0x1019af4c */
            ii(0x1019_af4b, 1); inc(edx);                               /* inc edx */
        l_0x1019_af4c:
            ii(0x1019_af4c, 1); dec(edx);                               /* dec edx */
        l_0x1019_af4d:
            ii(0x1019_af4d, 3); mov(eax, memd[ds, ecx + 28]);           /* mov eax, [ecx+0x1c] */
            ii(0x1019_af50, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1019_af52, 2); if(jg(0x1019_af5f, 0xb)) goto l_0x1019_af5f; /* jg 0x1019af5f */
            ii(0x1019_af54, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1019_af56, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1019_af58, 2); if(jnz(0x1019_af5f, 5)) goto l_0x1019_af5f; /* jnz 0x1019af5f */
        l_0x1019_af5a:
            ii(0x1019_af5a, 5); mov(esi, 1);                            /* mov esi, 0x1 */
        l_0x1019_af5f:
            ii(0x1019_af5f, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1019_af61, 2); if(jz(0x1019_af6e, 0xb)) goto l_0x1019_af6e; /* jz 0x1019af6e */
            ii(0x1019_af63, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1019_af65, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_af67, 5); call(/* sys */ 0x1019_af89, 0x1d);      /* call 0x1019af89 */
            ii(0x1019_af6c, 2); mov(edi, eax);                          /* mov edi, eax */
        l_0x1019_af6e:
            ii(0x1019_af6e, 4); mov(eax, memd[ss, esp + 20]);           /* mov eax, [esp+0x14] */
            ii(0x1019_af72, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_af74, 2); if(jz(0x1019_af7a, 4)) goto l_0x1019_af7a; /* jz 0x1019af7a */
            ii(0x1019_af76, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1019_af78, 2); mov(edi, eax);                          /* mov edi, eax */
        l_0x1019_af7a:
            ii(0x1019_af7a, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1019_af7c, 3); mov(memd[ds, ecx + 32], edi);           /* mov [ecx+0x20], edi */
            ii(0x1019_af7f, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1019_af82, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_af83, 1); pop(edi);                               /* pop edi */
            ii(0x1019_af84, 1); pop(esi);                               /* pop esi */
            ii(0x1019_af85, 1); pop(edx);                               /* pop edx */
            ii(0x1019_af86, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_af87, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_af88, 1); ret();                                  /* ret */
        }
    }
}
