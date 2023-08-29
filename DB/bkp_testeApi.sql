--
-- PostgreSQL database dump
--

SET statement_timeout = 0;
SET client_encoding = 'LATIN1';
SET standard_conforming_strings = off;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET escape_string_warning = off;

--
-- Name: plpgsql; Type: PROCEDURAL LANGUAGE; Schema: -; Owner: postgres
--

CREATE OR REPLACE PROCEDURAL LANGUAGE plpgsql;


ALTER PROCEDURAL LANGUAGE plpgsql OWNER TO postgres;

SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- Name: TbProdutos; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "TbProdutos" (
    id integer NOT NULL,
    nome character varying(100) NOT NULL,
    preco numeric NOT NULL,
    descricao character varying(200) NOT NULL
);


ALTER TABLE public."TbProdutos" OWNER TO postgres;

--
-- Name: TbProdutos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE "TbProdutos_id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."TbProdutos_id_seq" OWNER TO postgres;

--
-- Name: TbProdutos_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE "TbProdutos_id_seq" OWNED BY "TbProdutos".id;


--
-- Name: TbProdutos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('"TbProdutos_id_seq"', 39, true);


--
-- Name: __EFMigrationsHistory; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);


ALTER TABLE public."__EFMigrationsHistory" OWNER TO postgres;

--
-- Name: tb_Aluno; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "tb_Aluno" (
    id_aluno integer NOT NULL,
    "Nome" character varying(30),
    data_nasc date,
    controle bit(1)
);


ALTER TABLE public."tb_Aluno" OWNER TO postgres;

--
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE "TbProdutos" ALTER COLUMN id SET DEFAULT nextval('"TbProdutos_id_seq"'::regclass);


--
-- Data for Name: TbProdutos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "TbProdutos" (id, nome, preco, descricao) FROM stdin;
1	Caneta Bic Azul	4.5	Caneta Bic Azul 1.0
2	Caderno 10 Mat	14.6	Caderno 10 Mat Tilibra
3	Borracha Mercur	2.8	Borracha Mercur 50
9	Lapiseira	6.45	Lapiseira 0.7
10	Mochila	60.00	Mochila
11	Caneta Bic Vermelha	4.5	Caneta Bic Vermelha 1.0
12	Lápis de Cor	12.0	Lápis de Cor 24 cores
13	Lápis de Cor	12.0	Lápis de Cor 24 cores
14	Lápis de Cor	12.0	Lápis de Cor 24 cores
15	Lápis de Cor	12.0	Lápis de Cor 24 cores
16	Caneca 200 ml	10.50	Caneca 200 ml
17	Bola de futebol	15.00	Bola de futebol
18	Gilete	3.60	Gilete
19	Isqueiro	8.60	Isqueiro
20	Caneta Bic Rosa	4.5	Caneta Bic Rosa
21	Caneta Bic Verde	4.5	Caneta Bic Verde
22	Lápis de Cor1	12.0	Lápis de Cor1
23	Lápis de Cor2	12.0	Lápis de Cor2
24	Lápis de Cor1	12.0	Lápis de Cor1
25	Lápis de Cor2	12.0	Lápis de Cor2
26	Lápis de Cor1	12.0	Lápis de Cor1
27	Lápis de Cor2	12.0	Lápis de Cor2
28	Lápis de Cor3	12.0	Lápis de Cor3
29	Lápis de Cor4	12.0	Lápis de Cor4
30	Lapiseira	8	Lapiseira 0.5
31	Caderno de desenho	7	Caderno de desenho grande 45 fls
32	Lapiseira	8	Lapiseira 0.5
33	Caderno de desenho	7	Caderno de desenho grande 45 fls
34	Lapiseira	830.0	Lapiseira 0.5
35	Caderno de desenho	765.0	Caderno de desenho grande 45 fls
36	Lapiseira	8.30	Lapiseira 0.5
37	Caderno de desenho	7.65	Caderno de desenho grande 45 fls
38	Lapiseira	8.30	Lapiseira 0.5
39	Caderno de desenho	7.65	Caderno de desenho grande 45 fls
\.


--
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
20230813205918_AdicionandoProdutoDataNoDb	7.0.10
20230813211215_AdicionandoProdutoDataNoDb	7.0.10
20230813222535_AdicionandoProdutoDataNoDB	7.0.10
20230813225006_AdicionandoProdutoDataNoDB	7.0.10
20230814233622_SeedData	7.0.10
\.


--
-- Data for Name: tb_Aluno; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "tb_Aluno" (id_aluno, "Nome", data_nasc, controle) FROM stdin;
1	Tertuliano	2005-05-12	0
2	Jaboatino	2003-04-14	0
3	Cabrolino	1997-01-06	0
\.


--
-- Name: PK_TbProdutos; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "TbProdutos"
    ADD CONSTRAINT "PK_TbProdutos" PRIMARY KEY (id);


--
-- Name: PK___EFMigrationsHistory; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");


--
-- Name: tb_Aluno_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "tb_Aluno"
    ADD CONSTRAINT "tb_Aluno_pkey" PRIMARY KEY (id_aluno);


--
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


--
-- PostgreSQL database dump complete
--

